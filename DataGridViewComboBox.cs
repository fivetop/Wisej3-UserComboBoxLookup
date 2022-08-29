using System;
using System.ComponentModel;
using System.Threading;
using Wisej.Web;

namespace Wisej.UserComboBoxLookup
{
	public class DataGridViewComboBox : UserComboBox
	{
		private JavaScript javaScript1;
		private IContainer components;
		private System.Threading.Timer timer;

		public DataGridViewComboBox()
		{
			base.DropDownControl = CreateDropDownDataGrid();
			this.AutoCompleteMode = AutoCompleteMode.Suggest;

			this.KeyDown += DataGridViewComboBox_KeyDown;
			this.DataGridView.SelectionChanged += DataGridView_SelectionChanged;
			this.timer = Application.StartTimer(Timeout.Infinite, Timeout.Infinite, this.FilterRows);
			this.GotFocus += InheritedTextBox_GotFocus;
		}

        private void InheritedTextBox_GotFocus(object sender, EventArgs e)
        {
			this.Call("tst");

		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.timer.Dispose();
			}

			base.Dispose(disposing);
		}

		/// <summary>
		/// Returns or sets the selected item .
		/// </summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataGridViewRow SelectedItem
		{
			get { return this.DataGridView.CurrentRow; }
		}

		/// <summary>
		/// Returns or sets the index of the currently selected item.
		/// </summary>
		/// <returns>A zero-based index of the currently selected item. -1 if no item is selected.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The specified index is less than -1; o the specified index is greater than the number of items in the combo box. </exception>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override int SelectedIndex
		{
			get
			{
				// return the index of the selected item.
				return this.DataGridView.CurrentCellAddress.Y;
			}

			set
			{
				if (value < -1 || value > this.DataGridView.RowCount)
					throw new ArgumentOutOfRangeException("SelectedIndex");

				this.DataGridView.SetCurrentCell(-1, value);
			}
		}

		private void DataGridView_SelectionChanged(object sender, EventArgs e)
		{
			this.Call("myTest", this.DataGrid.CurrentCellAddress);

			OnSelectedItemChanged(EventArgs.Empty);
			OnSelectedIndexChanged(EventArgs.Empty);
		}

		private void DataGridViewComboBox_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up:
					MoveSelection(-1);
					break;

				case Keys.Down:
					MoveSelection(1);
					break;

				default:
					this.timer.Change(1000, Timeout.Infinite);
					// FilterRows();
					break;
			}
		}

		private void FilterRows()
		{
			var text = this.Text;
			var grid = this.DataGridView;
			for (var r = 0; r < grid.RowCount; r++)
			{
				var match = false;
				for (var c = 0; c < grid.ColumnCount; c++)
				{
					var value = Convert.ToString(grid.GetValue(c, r));
					match |= value.IndexOf(text, StringComparison.OrdinalIgnoreCase) > -1;
					if (match)
						break;
				}

				if (match)
					grid.Rows[r].Visible = true;
				else
					grid.Rows[r].Visible = false;
			}

			Application.Update(this);
		}

		private void MoveSelection(int delta)
		{
			var grid = this.DataGridView;
			var current = this.DataGridView.CurrentCellAddress;

			current.Y += delta;

			if (grid.IsValidRow(current.Y))
			{
				if (!grid.GetRowState(current.Y).HasFlag(DataGridViewElementStates.Visible))
				{
					if (delta > 0)
						current.Y = grid.Rows.GetNextRowIndex(current.Y, DataGridViewElementStates.Visible);
					else
						current.Y = grid.Rows.GetPreviousRowIndex(current.Y, DataGridViewElementStates.Visible);
				}

				if (grid.IsValidRow(current.Y))
				{
					grid.SetCurrentCell(current);
				}
			}
		}

		private DataGridView DataGridView
		{
			get { return (DataGridView)base.DropDownControl; }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override Control DropDownControl
		{
			get { return base.DropDownControl; }
			set { throw new NotSupportedException(); }
		}

		private DataGridView dataGrid;
		public DataGridView DataGrid
        {
			get { return dataGrid; }
        }

		private DataGridView CreateDropDownDataGrid()
		{
			dataGrid = new DataGridView() {
				Focusable = false
			};

			dataGrid.Columns.Add("Name");
			dataGrid.Columns.Add("Description");
			dataGrid.RowCount = 100;
			dataGrid.RowHeadersVisible = false;
			for (var r = 0; r < dataGrid.RowCount; r++)
			{
				dataGrid.SetValue(0, r, $"Row {r}, Column 0");
				dataGrid.SetValue(1, r, $"Row {r}, Column 1");
			}

			return dataGrid;
		}

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.javaScript1 = new Wisej.Web.JavaScript(this.components);
            this.SuspendLayout();
            // 
            // DataGridViewComboBox
            // 
            this.Name = "DataGridViewComboBox";
            this.SelectedItemChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            this.KeyDown += new Wisej.Web.KeyEventHandler(this.DataGridViewComboBox_KeyDown_1);
            this.ResumeLayout(false);

        }

        private void DataGridViewComboBox_KeyDown_1(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
            {
				this.Text = this.DataGrid.CurrentRow["Name"].Value.ToString();
				this.Call("close");
			}
        }
	}
}