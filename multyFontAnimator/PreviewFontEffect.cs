using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multyFontAnimator
{
	public partial class PreviewFontEffect : Form
	{
		public PreviewFontEffect()
		{
			InitializeComponent();
		}
		public PreviewFontEffect(string message, Size recSize):
			this()
		{
			this.label_main.Text = message;
			this.recSize = recSize;

			Bitmap bmp = new Bitmap(this.label_main.Width, this.label_main.Height);
			Graphics g = Graphics.FromImage(bmp);
			Rectangle rec = new Rectangle(
				(bmp.Width - recSize.Width) / 2,
				(bmp.Height - recSize.Height) / 2,
				recSize.Width,
				recSize.Height);
			g.DrawRectangle(new Pen(Color.Black), rec);
			this.label_main.Image = bmp;
		}

		Size recSize;

		public void changeFont(Font font)
		{
			this.label_main.Font = font;
		}
	}
}
