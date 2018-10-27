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

        public MainForm()
        {
            InitializeComponent();
        }

        private void Refresh(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = orderService.List;
            orderDataGridView.Refresh();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            new AddOrderForm().ShowDialog();

            orderBindingSource.DataSource = orderService.List;
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
                    orderService.RemoveOrder(orderDataGridView.SelectedRows[i].Index);
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
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
                    orderService.SaveStatus(saveFileDialog.FileName);
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
                    orderService.ReadStatus(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Error occurs while loading data.", "Error");
                }
            }
        }
    }
}
