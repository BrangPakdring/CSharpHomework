using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program1;

namespace Program1
{
	public partial class MainForm : Form
	{
		private OrderService orderService = OrderService.GetInstance();
		object currentList;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Refresh(object sender, EventArgs e)
		{
			orderBindingSource.DataSource = currentList ?? orderService.List;
			orderDataGridView.Refresh();
			Refresh();
		}

		private void AddOrderButton_Click(object sender, EventArgs e)
		{
			new OrderDetailsForm().ShowDialog();
			Refresh(sender, e);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			orderBindingSource.DataSource = orderService.List;
		}

		private void RemoveOrderButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (orderDataGridView.SelectedRows.Count == 0) throw new Exception();
				for (var i = orderDataGridView.SelectedRows.Count - 1; i >= 0; --i)
				{
					orderService.RemoveAll(order => order.Equals(orderDataGridView.SelectedRows[i].DataBoundItem as Order));
//					orderService.RemoveOrder(orderDataGridView.SelectedRows[i].Index);
				}
				Refresh(sender, e);
			}
			catch
			{
				MessageBox.Show("Please select rows to delete.");
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				InitialDirectory = Directory.GetCurrentDirectory(),
				Filter = "All Files (*.*)|*.*|XML File (*.xml)|*.xml",
				FilterIndex = 2
			};

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					orderService.ExportList(saveFileDialog.FileName);
				}
				catch
				{
					MessageBox.Show("Error occurs while saving data.", "Error");
				}
			}
		}

		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				InitialDirectory = Directory.GetCurrentDirectory(),
				Filter = "All Files (*.*)|*.*|XML File (*.xml)|*.xml",
				FilterIndex = 2
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					orderService.ImportList(openFileDialog.FileName);
					Refresh(sender, e);
				}
				catch
				{
					MessageBox.Show("Error occurs while loading data.", "Error");
				}
			}
		}

		private void ModifyOrderButton_Click(object sender, EventArgs e)
		{
			if (orderDataGridView.SelectedRows.Count != 1)
			{
				MessageBox.Show("Please select exactly one row to modify.");
				return;
			}
			var row = orderDataGridView.SelectedRows[0];
			new OrderDetailsForm(row.DataBoundItem as Order, row.Index).ShowDialog();
			Refresh(sender, e);
		}

		private void NewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			orderService.RemoveAll(o => o is Order);
			Refresh(sender, e);
		}

		private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			orderService.ExportList();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Thank you for using.", "About");
		}

		private void FindOrderButton_Click(object sender, EventArgs e)
		{
			List<Func<Order, bool>> funcs = new List<Func<Order, bool>>();
			if (clientNameTextBox.Text != "")
			{
				funcs.Add(order => order.Client.Name == clientNameTextBox.Text);
			}
			try
			{
				if (costFromTextBox.Text != "")
				{
					var from = Convert.ToDecimal(costFromTextBox.Text);
					funcs.Add(order => order.Cost >= from);
				}
				if (costToTextBox.Text != "")
				{
					var to = Convert.ToDecimal(costToTextBox.Text);
					funcs.Add(order => order.Cost < to);
				}
			}
			catch
			{
				MessageBox.Show("Invalid range number");
				return;
			}

			if (funcs.Count == 0)
			{
				currentList = orderService.List;
			}
			else
			{
				currentList =
					orderService.FindAll(order =>
					{
						var res = true;
						foreach (var cond in funcs) res &= cond(order);
						return res;
					});
			}
			Refresh(sender, e);
		}

		private void ResetOrderButton_Click(object sender, EventArgs e)
		{
			currentList = null;
			Refresh(sender, e);
		}

		private void SaveAsHTMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			orderService.ExportList();
			orderService.ExportHTML(orderService.SavingPath, "OrderList.xslt", "./tmp.html");

		}
	}
}
