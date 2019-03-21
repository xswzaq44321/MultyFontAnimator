namespace multyFontAnimator
{
	partial class FontManager
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button_OK = new System.Windows.Forms.Button();
			this.listBox_unchecked = new System.Windows.Forms.ListBox();
			this.listBox_checked = new System.Windows.Forms.ListBox();
			this.button_add = new System.Windows.Forms.Button();
			this.button_remove = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioButton_italic = new System.Windows.Forms.RadioButton();
			this.radioButton_boldItalic = new System.Windows.Forms.RadioButton();
			this.radioButton_bold = new System.Windows.Forms.RadioButton();
			this.radioButton_normal = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.button_preview = new System.Windows.Forms.Button();
			this.checkBox_fixedLength = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_OK
			// 
			this.button_OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_OK.Location = new System.Drawing.Point(606, 505);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(166, 44);
			this.button_OK.TabIndex = 1;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// listBox_unchecked
			// 
			this.listBox_unchecked.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_unchecked.FormattingEnabled = true;
			this.listBox_unchecked.ItemHeight = 12;
			this.listBox_unchecked.Location = new System.Drawing.Point(3, 3);
			this.listBox_unchecked.Name = "listBox_unchecked";
			this.listBox_unchecked.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox_unchecked.Size = new System.Drawing.Size(342, 481);
			this.listBox_unchecked.TabIndex = 2;
			this.listBox_unchecked.SelectedIndexChanged += new System.EventHandler(this.listBox_unchecked_SelectedIndexChanged);
			// 
			// listBox_checked
			// 
			this.listBox_checked.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_checked.FormattingEnabled = true;
			this.listBox_checked.ItemHeight = 12;
			this.listBox_checked.Location = new System.Drawing.Point(413, 3);
			this.listBox_checked.Name = "listBox_checked";
			this.listBox_checked.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox_checked.Size = new System.Drawing.Size(344, 481);
			this.listBox_checked.TabIndex = 3;
			this.listBox_checked.SelectedIndexChanged += new System.EventHandler(this.listBox_checked_SelectedIndexChanged);
			// 
			// button_add
			// 
			this.button_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button_add.AutoSize = true;
			this.button_add.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_add.Location = new System.Drawing.Point(3, 3);
			this.button_add.Name = "button_add";
			this.button_add.Size = new System.Drawing.Size(50, 50);
			this.button_add.TabIndex = 4;
			this.button_add.Text = ">>>";
			this.button_add.UseVisualStyleBackColor = true;
			this.button_add.Click += new System.EventHandler(this.button_add_Click);
			// 
			// button_remove
			// 
			this.button_remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_remove.AutoSize = true;
			this.button_remove.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_remove.Location = new System.Drawing.Point(3, 59);
			this.button_remove.Name = "button_remove";
			this.button_remove.Size = new System.Drawing.Size(50, 50);
			this.button_remove.TabIndex = 5;
			this.button_remove.Text = "<<<";
			this.button_remove.UseVisualStyleBackColor = true;
			this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox_unchecked, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.listBox_checked, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 487);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.button_remove);
			this.panel1.Controls.Add(this.button_add);
			this.panel1.Location = new System.Drawing.Point(351, 187);
			this.panel1.MinimumSize = new System.Drawing.Size(56, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(56, 112);
			this.panel1.TabIndex = 7;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDown1.Location = new System.Drawing.Point(202, 527);
			this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.radioButton_italic);
			this.panel2.Controls.Add(this.radioButton_boldItalic);
			this.panel2.Controls.Add(this.radioButton_bold);
			this.panel2.Controls.Add(this.radioButton_normal);
			this.panel2.Location = new System.Drawing.Point(15, 505);
			this.panel2.MaximumSize = new System.Drawing.Size(181, 44);
			this.panel2.MinimumSize = new System.Drawing.Size(181, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(181, 44);
			this.panel2.TabIndex = 8;
			// 
			// radioButton_italic
			// 
			this.radioButton_italic.AutoSize = true;
			this.radioButton_italic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_italic.Location = new System.Drawing.Point(94, 3);
			this.radioButton_italic.Name = "radioButton_italic";
			this.radioButton_italic.Size = new System.Drawing.Size(50, 19);
			this.radioButton_italic.TabIndex = 3;
			this.radioButton_italic.Text = "italic";
			this.radioButton_italic.UseVisualStyleBackColor = true;
			// 
			// radioButton_boldItalic
			// 
			this.radioButton_boldItalic.AutoSize = true;
			this.radioButton_boldItalic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_boldItalic.Location = new System.Drawing.Point(94, 25);
			this.radioButton_boldItalic.Name = "radioButton_boldItalic";
			this.radioButton_boldItalic.Size = new System.Drawing.Size(77, 19);
			this.radioButton_boldItalic.TabIndex = 2;
			this.radioButton_boldItalic.Text = "bold italic";
			this.radioButton_boldItalic.UseVisualStyleBackColor = true;
			// 
			// radioButton_bold
			// 
			this.radioButton_bold.AutoSize = true;
			this.radioButton_bold.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_bold.Location = new System.Drawing.Point(3, 25);
			this.radioButton_bold.Name = "radioButton_bold";
			this.radioButton_bold.Size = new System.Drawing.Size(49, 19);
			this.radioButton_bold.TabIndex = 1;
			this.radioButton_bold.Text = "bold";
			this.radioButton_bold.UseVisualStyleBackColor = true;
			// 
			// radioButton_normal
			// 
			this.radioButton_normal.AutoSize = true;
			this.radioButton_normal.Checked = true;
			this.radioButton_normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton_normal.Location = new System.Drawing.Point(3, 3);
			this.radioButton_normal.Name = "radioButton_normal";
			this.radioButton_normal.Size = new System.Drawing.Size(64, 19);
			this.radioButton_normal.TabIndex = 0;
			this.radioButton_normal.TabStop = true;
			this.radioButton_normal.Text = "normal";
			this.radioButton_normal.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(202, 505);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "size(em)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_preview
			// 
			this.button_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button_preview.Location = new System.Drawing.Point(434, 505);
			this.button_preview.Name = "button_preview";
			this.button_preview.Size = new System.Drawing.Size(166, 44);
			this.button_preview.TabIndex = 10;
			this.button_preview.Text = "Open Font Preview";
			this.button_preview.UseVisualStyleBackColor = true;
			this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
			// 
			// checkBox_fixedLength
			// 
			this.checkBox_fixedLength.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox_fixedLength.Location = new System.Drawing.Point(328, 505);
			this.checkBox_fixedLength.Name = "checkBox_fixedLength";
			this.checkBox_fixedLength.Size = new System.Drawing.Size(100, 44);
			this.checkBox_fixedLength.TabIndex = 11;
			this.checkBox_fixedLength.Text = "toggle fixed string length";
			this.checkBox_fixedLength.UseVisualStyleBackColor = true;
			this.checkBox_fixedLength.CheckedChanged += new System.EventHandler(this.checkBox_fixedLength_CheckedChanged);
			// 
			// FontManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.checkBox_fixedLength);
			this.Controls.Add(this.button_preview);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.button_OK);
			this.MinimumSize = new System.Drawing.Size(402, 240);
			this.Name = "FontManager";
			this.Text = "FontManager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FontManager_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.ListBox listBox_unchecked;
		private System.Windows.Forms.ListBox listBox_checked;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_remove;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton radioButton_italic;
		private System.Windows.Forms.RadioButton radioButton_boldItalic;
		private System.Windows.Forms.RadioButton radioButton_bold;
		private System.Windows.Forms.RadioButton radioButton_normal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_preview;
		private System.Windows.Forms.CheckBox checkBox_fixedLength;
	}
}