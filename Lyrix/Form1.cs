using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using mp3Lyric;
using iTunesLib;
using System.Drawing;
using System.Collections.Generic;

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

		public Form1()
		{
			InitializeComponent();
		}

		private void LeaveLog(string message)
		{
			richTextBox1.AppendText("[" + DateTime.Now.ToLongTimeString() + "] " + message + "\r\n");
		}

		private void iTunesと連携ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LeaveLog("iTunesの曲を取得しています。");
			LeaveLog("これにはしばらく時間がかかることがあります。");

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
				if (string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()) | string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
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
				
				var lg = new LyricGetter(artist, title);
				var lyric = lg.GetLyric().TrimEnd(); //最後の空白文字を削除

				if (lyric == null)
				{
					LeaveLog("Failed! => " + title + "/" + artist);
					continue;
				}
				else
				{
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
			IEnumerable<DataGridViewCell> cells;
			
			try
			{
				cells = dataGridView1.SelectedCells.Cast<DataGridViewCell>();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			foreach (var c in cells)
			{
				try
				{
					dataGridView1.Rows[c.RowIndex].Selected = true;
					label5.Text = dataGridView1.SelectedRows.Count + "曲";
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