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
	public partial class AnimateSetting : Form
	{
		public AnimateSetting()
		{
			InitializeComponent();
		}

		public event EventHandler OK;
		public int timerInterval { get { return (int)numericUpDown1.Value; } }

		private void button_OK_Click(object sender, EventArgs e)
		{
			OK?.Invoke(null, null);
			this.Hide();
		}

		private void AnimateSetting_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
