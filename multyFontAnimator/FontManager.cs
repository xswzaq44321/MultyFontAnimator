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
		}

		public FontFamily[] fonts { get { return selectedFonts.Values.ToArray(); } }
		public float size { get { return (float)this.numericUpDown1.Value; } }
		public Size recSize;
		public string message;
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
		public event EventHandler fontSettingOK;
		private SortedList<string, FontFamily> selectedFonts = new SortedList<string, FontFamily>(FontFamily.Families.Count());
		private SortedList<string, FontFamily> unselectedFonts = new SortedList<string, FontFamily>(FontFamily.Families.Count());
		private PreviewFontEffect viewEffect;

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
			viewEffect?.changeFont(new Font(unselectedFonts.Values[listBox_unchecked.SelectedIndex], this.size, this.style));
		}

		private void listBox_checked_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox_checked.SelectedIndex == -1)
				return;
			viewEffect?.changeFont(new Font(selectedFonts.Values[listBox_checked.SelectedIndex], this.size, this.style));
		}

		private void checkBox_fixedLength_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
