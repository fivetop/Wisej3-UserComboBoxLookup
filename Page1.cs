
using System;
using Wisej.Web;

namespace Wisej.UserComboBoxLookup
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void dataGridViewComboBox1_SelectedItemChanged(object sender, EventArgs e)
		{
			this.label1.Text = this.dataGridViewComboBox1.SelectedItem?.ToString() ?? "";
			//this.Eval("console.log(this.toString())");
			//this.Eval("tst()");
		}

		private void listViewComboBox1_SelectedItemChanged(object sender, EventArgs e)
		{

		}

        private void comboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
		}

        private void Page1_Load(object sender, EventArgs e)
        {
			// inheritedTextBox1.Text = Wisej.Core.ClientPlatform
		}
    }
}
