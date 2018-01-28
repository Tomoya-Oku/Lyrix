namespace Lyrix
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.切り取り = new System.Windows.Forms.ToolStripMenuItem();
			this.貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.新しい項目を追加 = new System.Windows.Forms.ToolStripMenuItem();
			this.この項目を削除 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.iTunesと連携ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.歌詞フォルダを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Location = new System.Drawing.Point(0, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(624, 300);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "曲名";
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.Width = 54;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "アーティスト";
			this.Column2.Name = "Column2";
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.Width = 82;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "アルバム";
			this.Column3.Name = "Column3";
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.Width = 69;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.コピー,
            this.切り取り,
            this.貼り付け,
            this.新しい項目を追加,
            this.この項目を削除});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(221, 114);
			// 
			// コピー
			// 
			this.コピー.Name = "コピー";
			this.コピー.Size = new System.Drawing.Size(220, 22);
			this.コピー.Text = "コピー";
			this.コピー.Click += new System.EventHandler(this.コピー_Click);
			// 
			// 切り取り
			// 
			this.切り取り.Name = "切り取り";
			this.切り取り.Size = new System.Drawing.Size(220, 22);
			this.切り取り.Text = "切り取り";
			this.切り取り.Click += new System.EventHandler(this.切り取り_Click);
			// 
			// 貼り付け
			// 
			this.貼り付け.Name = "貼り付け";
			this.貼り付け.Size = new System.Drawing.Size(220, 22);
			this.貼り付け.Text = "貼り付け";
			this.貼り付け.Click += new System.EventHandler(this.貼り付け_Click);
			// 
			// 新しい項目を追加
			// 
			this.新しい項目を追加.Name = "新しい項目を追加";
			this.新しい項目を追加.Size = new System.Drawing.Size(220, 22);
			this.新しい項目を追加.Text = "新しい項目を追加（Ctrl+N）";
			this.新しい項目を追加.Click += new System.EventHandler(this.新しい項目を追加_Click);
			// 
			// この項目を削除
			// 
			this.この項目を削除.Name = "この項目を削除";
			this.この項目を削除.Size = new System.Drawing.Size(220, 22);
			this.この項目を削除.Text = "この項目を削除（Ctrl+D）";
			this.この項目を削除.Click += new System.EventHandler(this.この項目を削除_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iTunesと連携ToolStripMenuItem,
            this.歌詞フォルダを開くToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// iTunesと連携ToolStripMenuItem
			// 
			this.iTunesと連携ToolStripMenuItem.Name = "iTunesと連携ToolStripMenuItem";
			this.iTunesと連携ToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.iTunesと連携ToolStripMenuItem.Text = "iTunesと連携";
			this.iTunesと連携ToolStripMenuItem.Click += new System.EventHandler(this.iTunesと連携ToolStripMenuItem_Click);
			// 
			// 歌詞フォルダを開くToolStripMenuItem
			// 
			this.歌詞フォルダを開くToolStripMenuItem.Name = "歌詞フォルダを開くToolStripMenuItem";
			this.歌詞フォルダを開くToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.歌詞フォルダを開くToolStripMenuItem.Text = "歌詞フォルダを開く";
			this.歌詞フォルダを開くToolStripMenuItem.Click += new System.EventHandler(this.歌詞フォルダを開くToolStripMenuItem_Click);
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// ヘルプToolStripMenuItem
			// 
			this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
			this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.ヘルプToolStripMenuItem.Text = "ヘルプ";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(12, 348);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(294, 54);
			this.button1.TabIndex = 2;
			this.button1.Text = "START";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(312, 330);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(300, 99);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 333);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "すべての曲:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 333);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "0曲";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(170, 333);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "選択中の曲";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(239, 333);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 12);
			this.label5.TabIndex = 9;
			this.label5.Text = "0曲";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 413);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(246, 16);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Second（二個目の項目の歌詞を取得します。）";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "Lyrix";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem iTunesと連携ToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 新しい項目を追加;
		private System.Windows.Forms.ToolStripMenuItem この項目を削除;
		private System.Windows.Forms.ToolStripMenuItem コピー;
		private System.Windows.Forms.ToolStripMenuItem 切り取り;
		private System.Windows.Forms.ToolStripMenuItem 貼り付け;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ToolStripMenuItem 歌詞フォルダを開くToolStripMenuItem;
	}
}

