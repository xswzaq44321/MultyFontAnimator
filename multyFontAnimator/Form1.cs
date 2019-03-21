using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using multyFontAnimator;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			standardFont = (Font)this.label_main.Font.Clone();
			this.fonts = fontManagerWindow.fonts;

			timer.Interval = 100;
			timer.Tick += (s, e) =>
			{
				label_main.Font = new Font(fonts[timerCount], standardFont.Size, standardFont.Style);
				if (++timerCount >= fonts.Count())
				{
					timerCount = 0;
				}
			};
			numericUpDown_width.ValueChanged += sizeValueChanged;
			numericUpDown_height.ValueChanged += sizeValueChanged;
			sizeValueChanged(null, null);

			editTextWindow.textChanged += (s, e) =>
			{
				this.label_main.Text = editTextWindow.text;
				fontManagerWindow.message = editTextWindow.text;
			};
			fontManagerWindow.fontSettingOK += (s, e) =>
			{
				this.fonts = fontManagerWindow.fonts;
				standardFont = new Font(standardFont.FontFamily, fontManagerWindow.size, fontManagerWindow.style);
				this.label_main.Font = standardFont;
			};
			animateSettingWindow.OK += (s, e) =>
			{
				timer.Interval = animateSettingWindow.timerInterval;
			};

			fontManagerWindow.message = this.label_main.Text;
		}

		System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
		int timerCount;
		bool onAnimating = false;
		Font standardFont;
		FontFamily[] fonts;
		EditText editTextWindow = new EditText();
		FontManager fontManagerWindow = new FontManager();
		AnimateSetting animateSettingWindow = new AnimateSetting();
		Size recSize;

		private void button_animate_Click(object sender, EventArgs e)
		{
			if (fonts.Count() == 0)
			{
				MessageBox.Show("請至少選擇一種字體!", "安捏母湯!", MessageBoxButtons.OK);
				return;
			}
			timer.Start();
			onAnimating = true;
		}

		private void button_pause_Click(object sender, EventArgs e)
		{
			timer.Stop();
		}

		private void button_reset_Click(object sender, EventArgs e)
		{
			timerCount = 0;
			label_main.Font = standardFont;
			timer.Stop();
			onAnimating = false;
		}

		private void sizeValueChanged(object sender, EventArgs e)
		{
			recSize = new Size((int)numericUpDown_width.Value, (int)numericUpDown_height.Value);
			Bitmap bmp = new Bitmap(this.label_main.Width, this.label_main.Height);
			Graphics g = Graphics.FromImage(bmp);
			Rectangle rec = new Rectangle(
				(bmp.Width - recSize.Width) / 2,
				(bmp.Height - recSize.Height) / 2,
				recSize.Width,
				recSize.Height);
			g.DrawRectangle(new Pen(Color.Black), rec);
			this.label_main.Image = bmp;

			fontManagerWindow.recSize = this.recSize;
		}

		private void 文字內容ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (onAnimating)
			{
				MessageBox.Show("動畫模擬中不能更改設定!", "安捏母湯!", MessageBoxButtons.OK);
				return;
			}
			editTextWindow.ShowDialog();
		}

		private void 字體管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (onAnimating)
			{
				MessageBox.Show("動畫模擬中不能更改設定!", "安捏母湯!", MessageBoxButtons.OK);
				return;
			}
			fontManagerWindow.ShowDialog();
		}

		private void 動畫設定ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (onAnimating)
			{
				MessageBox.Show("動畫模擬中不能更改設定!", "安捏母湯!", MessageBoxButtons.OK);
				return;
			}
			animateSettingWindow.ShowDialog();
		}

		private void 存檔ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}
	}
}
