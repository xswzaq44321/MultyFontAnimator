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
	public partial class EditText : Form
	{
		public EditText()
		{
			InitializeComponent();
		}

		public event EventHandler textChanged;
		public string text;

		private void EditText_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			text = this.textBox1.Text;
			textChanged?.Invoke(null, null);
		}
	}
}
