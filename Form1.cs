using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using mp3Lyric;
using iTunesLib;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace Lyrix
{
	public partial class Form1 : Form
	{
		#region "列の項目"

		private const int title = 0;
		private const int artist = 1;
		private const int album = 2;

		#endregion

		private Color BACKCOLOR = Color.SkyBlue; //既に歌詞がある場合の背景色

		private const string FOLDER_NAME = "Lyrics";

		public Form1()
		{
			InitializeComponent();
		}

		private void LeaveLog(string message)
		{
			richTextBox1.AppendText("[" + DateTime.Now.ToLongTimeString() + "] " + message + "\r\n");
		}

		private void SaveLyric(string lyric, string title, string artist)
		{
			var folderPath = Path.Combine(Environment.CurrentDirectory, FOLDER_NAME);

			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			var path = Path.Combine(folderPath, title + "[" + artist + "].txt");

			using (var stream = File.CreateText(path))
			{
				stream.Write(lyric);
				stream.Close();
			}
		}

		private void iTunesと連携ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LeaveLog("iTunesの曲を取得しています。");
			LeaveLog("これにはしばらく時間がかかることがあります。");

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				try
				{
					dataGridView1.Rows.Remove(row);
				}
				catch (InvalidCastException ex)
				{
					MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			
			iTunesApp app;

			try
			{
				app = new iTunesApp();
			}
			catch
			{
				MessageBox.Show("iTunesの起動に失敗しました。\nインストールされているか確認してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			IEnumerable<IITFileOrCDTrack> tracks = null;

			try
			{
				tracks = app.LibraryPlaylist.Tracks.Cast<IITFileOrCDTrack>().OrderBy(n => n.Name).Cast<IITFileOrCDTrack>(); ;
			}	
			catch (ArgumentNullException)
			{
				MessageBox.Show("曲が見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var i = 0;
			var error = 0;
			foreach (var t in tracks)
			{
				try
				{
					dataGridView1.Rows.Add();
					dataGridView1.Rows[i].Tag = t;
					dataGridView1.Rows[i].Cells[title].Value = t.Name;
					dataGridView1.Rows[i].Cells[artist].Value = t.Artist;
					dataGridView1.Rows[i].Cells[album].Value = t.Album;
				}
				catch
				{
					error++;
					continue;
				}

				//既に歌詞がある場合背景色を変更
				if (t.Lyrics != null)
				{
					dataGridView1.Rows[i].Cells[0].Style.BackColor = BACKCOLOR;
				}

				i++;
			}

			label3.Text = tracks.Count() + "曲";

			LeaveLog("iTunesの曲の取得が終了しました。");

			if (error != 0)
			{
				LeaveLog(error + "曲の取得に失敗しました。");
			}

			this.Activate();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows == null)
			{
				MessageBox.Show("曲が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			IEnumerable<DataGridViewRow> selectedRows = null;

			try
			{
				selectedRows = dataGridView1.SelectedRows.Cast<DataGridViewRow>();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			foreach (var row in selectedRows)
			{
				if (row.Cells[1].Value == null | row.Cells[0].Value == null)
				{
					LeaveLog("Failed! => ???/???");
					continue;
				}

				var artist = "";
				var title = "";

				try
				{
					artist = row.Cells[1].Value.ToString();
					title = row.Cells[0].Value.ToString();
				}
				catch
				{
					LeaveLog("Failed! => " + title + "/" + artist);
					continue;
				}				
				var lg = new LyricGetter(artist, title, checkBox1.Checked);

				if (lg.GetLyric() == null)
				{
					LeaveLog("Failed! => " + title + "/" + artist);
					continue;
				}

				var lyric = lg.GetLyric().TrimEnd(); //最後の空白文字を削除

				if (lyric == null)
				{
					LeaveLog("Failed! => " + title + "/" + artist);
					continue;
				}
				else
				{
					if (row.Tag == null)
					{
						LeaveLog("Success! => " + title + "/" + artist);
						SaveLyric(lyric, title, artist);
						return;
					}

					var track = (IITFileOrCDTrack)row.Tag;

					try
					{
						track.Lyrics = lyric;
					}
					catch
					{
						LeaveLog("Failed! => " + title + "/" + artist);
						continue;
					}
					
					LeaveLog("Success! => " + title + "/" + artist);
				}
			}
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (this.label5.Created)
			{
				label5.Text = dataGridView1.SelectedRows.Count + "曲";
			}
		}

		private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			label3.Text = dataGridView1.Rows.Count + "曲";
		}

		private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			label3.Text = dataGridView1.Rows.Count + "曲";
		}

		private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
		{
			label3.Text = dataGridView1.Rows.Count + "曲";
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void 新しい項目を追加_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.Rows.Add(1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void この項目を削除_Click(object sender, EventArgs e)
		{
			var selectedRows = dataGridView1.SelectedRows;

			foreach (DataGridViewRow row in selectedRows)
			{
				try
				{
					dataGridView1.Rows.Remove(row);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void コピー_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetDataObject(dataGridView1.SelectedRows);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void 切り取り_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetDataObject(dataGridView1.GetClipboardContent());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
			{
				try
				{
					dataGridView1.Rows.Remove(row);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		private void 貼り付け_Click(object sender, EventArgs e)
		{
			var copy = Clipboard.GetText();

			Console.WriteLine("Copy: " + copy);
		}

		private void 歌詞フォルダを開くToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start(Path.Combine(Environment.CurrentDirectory, FOLDER_NAME));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.N)
			{
				try
				{
					dataGridView1.Rows.Add(1);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			else if (e.Control && e.KeyCode == Keys.D)
			{
				var selectedRows = dataGridView1.SelectedRows;

				foreach (DataGridViewRow row in selectedRows)
				{
					try
					{
						dataGridView1.Rows.Remove(row);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
		}
	}
}