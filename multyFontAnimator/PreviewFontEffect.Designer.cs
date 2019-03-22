namespace multyFontAnimator
{
	partial class PreviewFontEffect
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
			this.label_main = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_main
			// 
			this.label_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label_main.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label_main.Location = new System.Drawing.Point(163, 107);
			this.label_main.Name = "label_main";
			this.label_main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label_main.Size = new System.Drawing.Size(354, 214);
			this.label_main.TabIndex = 0;
			this.label_main.Text = "xswzaq44321";
			this.label_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label_main);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(670, 447);
			this.panel1.TabIndex = 5;
			this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
			// 
			// PreviewFontEffect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(694, 471);
			this.Controls.Add(this.panel1);
			this.Name = "PreviewFontEffect";
			this.Text = "ViewMessage";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_main;
		private System.Windows.Forms.Panel panel1;
	}
}