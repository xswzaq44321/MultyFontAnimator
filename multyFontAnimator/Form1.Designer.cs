namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button_animate = new System.Windows.Forms.Button();
			this.button_pause = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.文字內容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.字體管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動畫ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.動畫設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.輸出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.存檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label_main = new System.Windows.Forms.Label();
			this.button_reset = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
			this.SuspendLayout();
			// 
			// button_animate
			// 
			this.button_animate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_animate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_animate.Location = new System.Drawing.Point(525, 380);
			this.button_animate.Name = "button_animate";
			this.button_animate.Size = new System.Drawing.Size(96, 50);
			this.button_animate.TabIndex = 1;
			this.button_animate.Text = "test animate";
			this.button_animate.UseVisualStyleBackColor = true;
			this.button_animate.Click += new System.EventHandler(this.button_animate_Click);
			// 
			// button_pause
			// 
			this.button_pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_pause.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_pause.Location = new System.Drawing.Point(423, 380);
			this.button_pause.Name = "button_pause";
			this.button_pause.Size = new System.Drawing.Size(96, 50);
			this.button_pause.TabIndex = 2;
			this.button_pause.Text = "test pause";
			this.button_pause.UseVisualStyleBackColor = true;
			this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編輯ToolStripMenuItem,
            this.動畫ToolStripMenuItem,
            this.輸出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(633, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 編輯ToolStripMenuItem
			// 
			this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字內容ToolStripMenuItem,
            this.字體管理ToolStripMenuItem});
			this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
			this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.編輯ToolStripMenuItem.Text = "編輯";
			// 
			// 文字內容ToolStripMenuItem
			// 
			this.文字內容ToolStripMenuItem.Name = "文字內容ToolStripMenuItem";
			this.文字內容ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.文字內容ToolStripMenuItem.Text = "文字內容";
			this.文字內容ToolStripMenuItem.Click += new System.EventHandler(this.文字內容ToolStripMenuItem_Click);
			// 
			// 字體管理ToolStripMenuItem
			// 
			this.字體管理ToolStripMenuItem.Name = "字體管理ToolStripMenuItem";
			this.字體管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.字體管理ToolStripMenuItem.Text = "字體管理";
			this.字體管理ToolStripMenuItem.Click += new System.EventHandler(this.字體管理ToolStripMenuItem_Click);
			// 
			// 動畫ToolStripMenuItem
			// 
			this.動畫ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.動畫設定ToolStripMenuItem});
			this.動畫ToolStripMenuItem.Name = "動畫ToolStripMenuItem";
			this.動畫ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.動畫ToolStripMenuItem.Text = "動畫";
			// 
			// 動畫設定ToolStripMenuItem
			// 
			this.動畫設定ToolStripMenuItem.Name = "動畫設定ToolStripMenuItem";
			this.動畫設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.動畫設定ToolStripMenuItem.Text = "動畫設定";
			this.動畫設定ToolStripMenuItem.Click += new System.EventHandler(this.動畫設定ToolStripMenuItem_Click);
			// 
			// 輸出ToolStripMenuItem
			// 
			this.輸出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.存檔ToolStripMenuItem});
			this.輸出ToolStripMenuItem.Name = "輸出ToolStripMenuItem";
			this.輸出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.輸出ToolStripMenuItem.Text = "存檔";
			// 
			// 存檔ToolStripMenuItem
			// 
			this.存檔ToolStripMenuItem.Name = "存檔ToolStripMenuItem";
			this.存檔ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.存檔ToolStripMenuItem.Text = "存檔";
			this.存檔ToolStripMenuItem.Click += new System.EventHandler(this.存檔ToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label_main);
			this.panel1.Location = new System.Drawing.Point(12, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(609, 347);
			this.panel1.TabIndex = 4;
			// 
			// label_main
			// 
			this.label_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_main.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_main.Location = new System.Drawing.Point(0, 0);
			this.label_main.Name = "label_main";
			this.label_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label_main.Size = new System.Drawing.Size(607, 345);
			this.label_main.TabIndex = 0;
			this.label_main.Text = "xswzaq44321";
			this.label_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_reset
			// 
			this.button_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button_reset.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button_reset.Location = new System.Drawing.Point(321, 380);
			this.button_reset.Name = "button_reset";
			this.button_reset.Size = new System.Drawing.Size(96, 50);
			this.button_reset.TabIndex = 5;
			this.button_reset.Text = "test reset";
			this.button_reset.UseVisualStyleBackColor = true;
			this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.numericUpDown_height);
			this.panel2.Controls.Add(this.numericUpDown_width);
			this.panel2.Location = new System.Drawing.Point(12, 380);
			this.panel2.MaximumSize = new System.Drawing.Size(275, 50);
			this.panel2.MinimumSize = new System.Drawing.Size(275, 50);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(275, 50);
			this.panel2.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F);
			this.label3.Location = new System.Drawing.Point(128, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 18);
			this.label3.TabIndex = 8;
			this.label3.Text = "X";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 18);
			this.label2.TabIndex = 7;
			this.label2.Text = "Width x Height";
			// 
			// numericUpDown_height
			// 
			this.numericUpDown_height.Location = new System.Drawing.Point(149, 21);
			this.numericUpDown_height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_height.Name = "numericUpDown_height";
			this.numericUpDown_height.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown_height.TabIndex = 1;
			this.numericUpDown_height.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
			// 
			// numericUpDown_width
			// 
			this.numericUpDown_width.Location = new System.Drawing.Point(6, 21);
			this.numericUpDown_width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_width.Name = "numericUpDown_width";
			this.numericUpDown_width.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown_width.TabIndex = 6;
			this.numericUpDown_width.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "GIF|*.gif";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 442);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button_reset);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button_pause);
			this.Controls.Add(this.button_animate);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button_animate;
		private System.Windows.Forms.Button button_pause;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 文字內容ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 字體管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 輸出ToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem 動畫ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 動畫設定ToolStripMenuItem;
		private System.Windows.Forms.Button button_reset;
		private System.Windows.Forms.ToolStripMenuItem 存檔ToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown_height;
		private System.Windows.Forms.NumericUpDown numericUpDown_width;
		private System.Windows.Forms.Label label_main;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

