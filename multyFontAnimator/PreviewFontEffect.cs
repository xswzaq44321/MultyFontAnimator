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
			this.label_main.Size = recSize;
			panel1_Resize(null, null);
		}

		public Font myFont
		{
			get
			{
				return this.label_main.Font;
			}
			set
			{
				this.label_main.Font = value;
			}
		}
		Size recSize;

		private void panel1_Resize(object sender, EventArgs e)
		{
			Point position = new Point();
			position.X = (this.panel1.Width - this.label_main.Width) / 2;
			position.Y = (this.panel1.Height - this.label_main.Height) / 2;
			this.label_main.Location = position;
		}
	}
}
