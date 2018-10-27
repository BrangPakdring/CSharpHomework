using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class AddOrderForm : Form
    {
        Order Order;
        public decimal Coste { set; get; }
        enum OperationStatus
        {
            Idle = 0b0,
            Added = 0b1,
            Removed = 0b10,
            Modified = 0b100,
        }
        OperationStatus operationStatus = OperationStatus.Idle;

        public AddOrderForm()
        {
            InitializeComponent();
            Order = new Order();
        }

        /// <summary>
        /// Manually refresh the table and total cost identifier... any better solutions??
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh(object sender, EventArgs e)
        {
            this.costLabel.DataBindings.Clear();
            this.costLabel.DataBindings.Add("Text", Order, "Cost");

            this.dataGridView1.Refresh();
            orderDetailsBindingSource.DataSource = typeof(Program1.OrderDetails);
        }

        /// <summary>
        /// Add events and bindings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrderForm_Load(object sender, EventArgs e)
        { 
            costLabel.DataBindings.Add("Text", Order, "Cost");
            orderIdLabel.DataBindings.Add("Text", Order, "Id");
            clientTextBox.DataBindings.Add("Text", Order, "Client.Name");
            
            dataGridView1.UserAddedRow += DataGridView1_UserAddedRow;
            dataGridView1.UserDeletingRow += DataGridView1_UserDeletingRow;
            dataGridView1.RowLeave += DataGridView1_RowLeave;
            dataGridView1.CellEndEdit += DataGridView1_CellEndEdit;

            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (operationStatus == OperationStatus.Added) return;
            operationStatus = OperationStatus.Modified;
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string msg;
            switch(dataGridView1.Columns[e.ColumnIndex].Name)
            {
                case "Count":
                case "ProductPrice":
                    msg = "Please input a non-negative integer.";
                    break;
                default:
                    msg = "Unknown Error";
                    break;
            }
            MessageBox.Show(msg, "Error");
        }

        /// <summary>
        /// Change the status to Added at the beginning of adding.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.operationStatus = OperationStatus.Added;
        }

        private void DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Order.RemoveOrderDetails(e.Row.Index);
        }

        /// <summary>
        /// If user leaves current row with new row added, that one will be pended to list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (operationStatus == OperationStatus.Added)
            {
                Order.AddOrderDetails(dataGridView1.CurrentRow.DataBoundItem as OrderDetails);
            }
            else if (operationStatus==OperationStatus.Modified)
            {
                OrderService.GetInstance().ModifyOrder(e.RowIndex, dataGridView1.Rows[e.RowIndex].DataBoundItem as Order);
            }
            operationStatus = OperationStatus.Idle;
            Refresh(sender, e);
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            var removedRows = this.dataGridView1.SelectedRows;
            for (var i = removedRows.Count - 1; i >= 0; --i)
            {
                Order.RemoveOrderDetails(removedRows[i].Index);
            }
        }

        /// <summary>
        /// Confirm and add the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            OrderService.GetInstance().AddOrder(Order);
            this.Dispose();
        }
    }
}
