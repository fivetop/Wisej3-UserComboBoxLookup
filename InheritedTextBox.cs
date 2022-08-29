using System;
using Wisej.Web;

namespace Wisej.UserComboBoxLookup
{
    public class InheritedTextBox : Wisej.Web.TextBox
    {
        private JavaScript javaScript1;
        private System.ComponentModel.IContainer components;

        public InheritedTextBox()
        {
            InitializeComponent();
            GotFocus += InheritedTextBox_GotFocus;
        }

        private void InheritedTextBox_GotFocus(object sender, EventArgs e)
        {
        }

		protected override void OnCreateControl()
		{

			base.OnCreateControl();
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.SuspendLayout();
            // 
            // InheritedTextBox
            // 
            this.javaScript1.SetJavaScriptSource(this, "InheritedTextBox.js");
            this.Name = "InheritedTextBox";
            this.Text = "InheritedControl1";
            this.Click += new System.EventHandler(this.InheritedTextBox_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private void InheritedTextBox_Click(object sender, EventArgs e)
        {
            this.Call("myTest", this.Text);
        }
    }
}
