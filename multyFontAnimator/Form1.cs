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
using System.Drawing.Imaging;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

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
				float size;
				if (fixedLength == -1)
				{
					size = standardFont.Size;
				}
				else
				{
					System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));
					SizeF sizef = graphics.MeasureString(this.label_main.Text, new Font(fonts[timerCount], standardFont.Size, standardFont.Style, GraphicsUnit.Point));
					size = fixedLength / sizef.Width * standardFont.Size;
				}
				label_main.Font = new Font(fonts[timerCount], size, standardFont.Style);
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
				this.fixedLength = fontManagerWindow.FixedLength;
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
		float fixedLength = -1;
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
			this.label_main.Size = recSize;
			panel1_Resize(null, null);

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
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
				foreach (var item in di.GetFiles())
				{
					if (Regex.Match(item.Name, @"frame\d*.png").Success)
					{
						item.Delete();
					}
				}
				for (int i = 0; i < fonts.Count(); ++i)
				{
					Bitmap bmp = new Bitmap(recSize.Width, recSize.Height);
					Graphics g = Graphics.FromImage(bmp);
					if (!animateSettingWindow.transparent)
						g.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
					StringFormat format = new StringFormat();
					format.LineAlignment = StringAlignment.Center;
					format.Alignment = StringAlignment.Center;
					float size;
					if (fixedLength == -1)
					{
						size = standardFont.Size;
					}
					else
					{
						System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));
						SizeF sizef = graphics.MeasureString(this.label_main.Text, new Font(fonts[i], standardFont.Size, standardFont.Style, GraphicsUnit.Point));
						size = fixedLength / sizef.Width * standardFont.Size;
					}
					g.DrawString(this.label_main.Text,
						new Font(fonts[i], size, standardFont.Style),
						Brushes.Black,
						new RectangleF(0, 0, bmp.Width, bmp.Height),
						format);
					bmp.Save(folderBrowserDialog1.SelectedPath + "\\frame" + i + ".png", ImageFormat.Png);
				}
			}
		}

		private void panel1_Resize(object sender, EventArgs e)
		{
			Point position = new Point();
			position.X = (this.panel1.Width - this.label_main.Width) / 2;
			position.Y = (this.panel1.Height - this.label_main.Height) / 2;
			this.label_main.Location = position;
		}

		private void 儲存設定ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Setting set = new Setting();
				set.message = this.label_main.Text;
				set.setFontFamilies(this.fonts);
				set.transparent = animateSettingWindow.transparent;
				set.size = this.recSize;
				set.msPerFrame = this.timer.Interval;
				set.style = this.standardFont.Style;
				set.fontSize = this.standardFont.Size;
				set.fixedSize = this.fixedLength;

				string jsonData = JsonConvert.SerializeObject(set);

				StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
				sw.Write(jsonData);
				sw.Close();
			}
		}

		private void 讀取設定ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StreamReader sr = new StreamReader(openFileDialog1.FileName);
				string jsonData = sr.ReadToEnd();
				sr.Close();

				Setting set = JsonConvert.DeserializeObject<Setting>(jsonData);
				this.label_main.Text = set.message;
				this.fonts = set.getFontFamilies();
				fontManagerWindow.setFonts(this.fonts);
				animateSettingWindow.transparent = set.transparent;
				this.recSize = set.size;
				this.timer.Interval = set.msPerFrame;
				animateSettingWindow.timerInterval = set.msPerFrame;
				this.standardFont = new Font(this.standardFont.FontFamily, set.fontSize, set.style);
				this.fixedLength = set.fixedSize;
				fontManagerWindow.FixedLength = set.fixedSize;
			}
		}
	}
}
