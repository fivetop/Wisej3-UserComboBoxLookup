
namespace Wisej.UserComboBoxLookup
{
	partial class Page1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Wisej.Web.ListViewItem listViewItem5 = new Wisej.Web.ListViewItem(new string[] {
            "Bubu",
            "aha"}, -1);
            Wisej.Web.ListViewItem listViewItem6 = new Wisej.Web.ListViewItem(new string[] {
            "Hahaha",
            "2. radek"}, -1);
            this.label1 = new Wisej.Web.Label();
            this.listViewComboBox1 = new Wisej.Web.ListViewComboBox();
            this.columnHeader1 = new Wisej.Web.ColumnHeader();
            this.columnHeader2 = new Wisej.Web.ColumnHeader();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.inheritedTextBox1 = new Wisej.UserComboBoxLookup.InheritedTextBox();
            this.dataGridViewComboBox1 = new Wisej.UserComboBoxLookup.DataGridViewComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // listViewComboBox1
            // 
            this.listViewComboBox1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.listViewComboBox1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewComboBox1.Items.AddRange(new Wisej.Web.ListViewItem[] {
            listViewItem5,
            listViewItem6});
            this.listViewComboBox1.Location = new System.Drawing.Point(423, 161);
            this.listViewComboBox1.Name = "listViewComboBox1";
            this.listViewComboBox1.Size = new System.Drawing.Size(164, 22);
            this.listViewComboBox1.TabIndex = 2;
            this.listViewComboBox1.Visible = false;
            this.listViewComboBox1.Watermark = "Test";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "Jméno";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "Adresa";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = Wisej.Web.AnchorStyles.Left;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(423, 165);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 22);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            this.comboBox1.Watermark = "Test3";
            this.comboBox1.SelectedItemChanged += new System.EventHandler(this.comboBox1_SelectedItemChanged);
            // 
            // inheritedTextBox1
            // 
            this.inheritedTextBox1.Location = new System.Drawing.Point(83, 161);
            this.inheritedTextBox1.Name = "inheritedTextBox1";
            this.inheritedTextBox1.Size = new System.Drawing.Size(235, 22);
            this.inheritedTextBox1.TabIndex = 4;
            this.inheritedTextBox1.Text = "";
            this.inheritedTextBox1.Watermark = "Text Box";
            // 
            // dataGridViewComboBox1
            // 
            this.dataGridViewComboBox1.AutoSize = false;
            this.javaScript1.SetJavaScriptSource(this.dataGridViewComboBox1, "DataGridViewComboBox.js");
            this.dataGridViewComboBox1.Location = new System.Drawing.Point(83, 70);
            this.dataGridViewComboBox1.Name = "dataGridViewComboBox1";
            this.dataGridViewComboBox1.Size = new System.Drawing.Size(117, 30);
            this.dataGridViewComboBox1.TabIndex = 0;
            this.dataGridViewComboBox1.Watermark = "Combo";
            this.dataGridViewComboBox1.SelectedItemChanged += new System.EventHandler(this.dataGridViewComboBox1_SelectedItemChanged);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.inheritedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listViewComboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewComboBox1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1055, 459);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DataGridViewComboBox dataGridViewComboBox1;
		private Web.Label label1;
		private Web.ListViewComboBox listViewComboBox1;
		private Web.ComboBox comboBox1;
        private Web.JavaScript javaScript1;
        private Web.ColumnHeader columnHeader1;
        private Web.ColumnHeader columnHeader2;
        private InheritedTextBox inheritedTextBox1;
    }
}

