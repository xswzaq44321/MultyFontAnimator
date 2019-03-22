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
	public partial class FontManager : Form
	{
		public FontManager()
		{
			InitializeComponent();

			// skips first one element, because it's a null font for some unknowned reason?
			for (int i = 1; i < FontFamily.Families.Count(); ++i)
			{
				selectedFonts.Add(FontFamily.Families[i].Name, FontFamily.Families[i]);
			}

			foreach (var item in unselectedFonts)
			{
				this.listBox_unchecked.Items.Add(item.Value.Name);
			}
			foreach (var item in selectedFonts)
			{
				this.listBox_checked.Items.Add(item.Value.Name);
			}
			this.listBox_unchecked.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBox_unchecked.DrawItem += new DrawItemEventHandler(listBox_unchecked_DrawItem);
			this.listBox_checked.DrawMode = DrawMode.OwnerDrawFixed;
			this.listBox_checked.DrawItem += new DrawItemEventHandler(listBox_checked_DrawItem);
			this.numericUpDown1.ValueChanged += (s, e) =>
			{
				if (viewEffect != null)
					viewEffect.myFont = new Font(viewEffect?.myFont.FontFamily, this.size, this.style);
				fixed_length = -1;
			};
			this.radioButton_normal.CheckedChanged += (s, e) =>
			{
				if (viewEffect != null)
					viewEffect.myFont = new Font(viewEffect?.myFont.FontFamily, this.size, this.style);
				fixed_length = -1;
			};
			this.radioButton_bold.CheckedChanged += (s, e) =>
			{
				if (viewEffect != null)
					viewEffect.myFont = new Font(viewEffect?.myFont.FontFamily, this.size, this.style);
				fixed_length = -1;
			};
			this.radioButton_italic.CheckedChanged += (s, e) =>
			{
				if (viewEffect != null)
					viewEffect.myFont = new Font(viewEffect?.myFont.FontFamily, this.size, this.style);
				fixed_length = -1;
			};
		}

		public FontFamily[] fonts { get { return selectedFonts.Values.ToArray(); } }
		public float size { get { return (float)this.numericUpDown1.Value; } }
		public Size recSize;
		public string message;
		public event EventHandler fontSettingOK;
		public float FixedLength
		{
			get
			{
				if (checkBox_fixedLength.Checked && fixed_length == -1)
				{
					Graphics g = Graphics.FromImage(new Bitmap(1, 1));
					FontFamily font = viewEffect == null ? fonts[0] : viewEffect.myFont.FontFamily;
					SizeF size = g.MeasureString(message, new Font(font, this.size, this.style, GraphicsUnit.Point));
					fixed_length = size.Width;
				}
				else if (!checkBox_fixedLength.Checked && fixed_length != -1)
				{
					fixed_length = -1;
				}
				return fixed_length;
			}
		}
		public FontStyle style
		{
			get
			{
				if (radioButton_normal.Checked)
					return FontStyle.Regular;
				else if (radioButton_bold.Checked)
					return FontStyle.Bold;
				else if (radioButton_italic.Checked)
					return FontStyle.Italic;
				else
					return FontStyle.Bold | FontStyle.Italic;
			}
		}
		private float fixed_length = -1;
		private SortedList<string, FontFamily> selectedFonts = new SortedList<string, FontFamily>(FontFamily.Families.Count());
		private SortedList<string, FontFamily> unselectedFonts = new SortedList<string, FontFamily>(FontFamily.Families.Count());
		private PreviewFontEffect viewEffect;

		void previewEffectDraw(FontFamily toDrawFont)
		{
			float size;
			if (this.FixedLength == -1)
			{
				size = this.size;
			}
			else
			{
				System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1));
				SizeF sizef = graphics.MeasureString(message, new Font(toDrawFont, this.size, this.style, GraphicsUnit.Point));
				size = this.FixedLength / sizef.Width * this.size;
			}
			viewEffect.myFont = new Font(toDrawFont, size, this.style);
		}

		void listBox_unchecked_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
				return;
			e.DrawBackground();
			Rectangle contentRect = e.Bounds;
			e.Graphics.DrawString(this.listBox_unchecked.Items[e.Index].ToString(),
				new Font(unselectedFonts.Values[e.Index], e.Font.Size),
				new SolidBrush(Color.Black),
				contentRect);
		}
		void listBox_checked_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == -1)
				return;
			e.DrawBackground();
			Rectangle contentRect = e.Bounds;
			e.Graphics.DrawString(this.listBox_checked.Items[e.Index].ToString(),
				new Font(selectedFonts.Values[e.Index], e.Font.Size),
				new SolidBrush(Color.Black),
				contentRect);
		}
		private void FontManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			viewEffect?.Close();
			this.Hide();
			e.Cancel = true;
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			for (int i = listBox_unchecked.SelectedIndex; i != -1; i = listBox_unchecked.SelectedIndex)
			{
				var bar = unselectedFonts.ElementAt(i);
				selectedFonts.Add(bar.Key, bar.Value);
				listBox_checked.Items.Insert(selectedFonts.IndexOfKey(bar.Key), bar.Value.Name);
				unselectedFonts.RemoveAt(i);
				listBox_unchecked.Items.RemoveAt(i);
			}
		}

		private void button_remove_Click(object sender, EventArgs e)
		{
			for (int i = listBox_checked.SelectedIndex; i != -1; i = listBox_checked.SelectedIndex)
			{
				var bar = selectedFonts.ElementAt(i);
				unselectedFonts.Add(bar.Key, bar.Value);
				listBox_unchecked.Items.Insert(unselectedFonts.IndexOfKey(bar.Key), bar.Value.Name);
				selectedFonts.RemoveAt(i);
				listBox_checked.Items.RemoveAt(i);
			}
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			this.Hide();
			viewEffect?.Close();
			fontSettingOK?.Invoke(null, null);
		}

		private void button_preview_Click(object sender, EventArgs e)
		{
			viewEffect?.Close();
			viewEffect = new PreviewFontEffect(message, recSize);
			viewEffect.Show();
		}

		private void listBox_unchecked_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox_unchecked.SelectedIndex == -1)
				return;
			if (viewEffect != null)
				previewEffectDraw(unselectedFonts.Values[listBox_unchecked.SelectedIndex]);
		}

		private void listBox_checked_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox_checked.SelectedIndex == -1)
				return;

			if (viewEffect != null)
				previewEffectDraw(selectedFonts.Values[listBox_checked.SelectedIndex]);
		}
	}
}
