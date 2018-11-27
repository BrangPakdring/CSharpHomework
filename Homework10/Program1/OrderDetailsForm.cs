using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
	public partial class OrderDetailsForm : Form
	{
		/// <summary>
		/// Current editing order.
		/// </summary>
		Order editingOrder;
		Order originOrder;

		/// <summary>
		/// Specify the operation status.
		/// </summary>
		enum OperationStatus
		{
			Idle = 0b0,
			Added = 0b1,
			Removed = 0b10,
			Modified = 0b100,
		}
		OperationStatus operationStatus = OperationStatus.Idle;

		/// <summary>
		/// Specify the reason entering.
		/// </summary>
		enum EnterType
		{
			Null,
			Add,
			Modify
		}
		EnterType enterType = EnterType.Null;

		/// <summary>
		/// For modification, use an index to specify the order.
		/// </summary>
		int modifyIndex;

		public OrderDetailsForm()
		{
			InitializeComponent();
			editingOrder = new Order(new Client(""));
			enterType = EnterType.Add;
		}

		/// <summary>
		/// Modify form.
		/// </summary>
		/// <param name="order"></param>
		/// <param name="index"></param>
		public OrderDetailsForm(Order order, int index)
		{
			InitializeComponent();
			editingOrder = new Order(order);
			enterType = EnterType.Modify;
//			foreach (var e in order.List)
//				orderDetailsBindingSource.List.Add(e);
			modifyIndex = index;
			originOrder = order;
		}

		/// <summary>
		/// Add events and bindings.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddOrderForm_Load(object sender, EventArgs e)
		{
			costLabel.DataBindings.Add("Text", editingOrder, "Cost");
			orderIdTextBox.DataBindings.Add("Text", editingOrder, "Id");
			clientTextBox.DataBindings.Add("Text", editingOrder, "Client.Name");
			phoneTextBox.DataBindings.Add("Text", editingOrder, "Client.PhoneNumber");

			orderBindingSource.DataSource = editingOrder;

			dataGridView1.DataError += DataGridView1_DataError;
			dataGridView1.CellLeave += DataGridView1_CellLeave;
		}

		private void DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			string msg;
			switch (dataGridView1.Columns[e.ColumnIndex].Name)
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
		/// Confirm and add the order.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ConfirmButton_Click(object sender, EventArgs e)
		{
			string msg = "";
			if (CheckValidity(ref msg) == false)
			{
				MessageBox.Show(msg, "Error");
				return;
			}
			if (enterType == EnterType.Modify)
			{
				OrderService.GetInstance().RemoveOrder(originOrder);
//				OrderService.GetInstance().RemoveAll(order0 => order0.Equals(originOrder));
			}
			OrderService.GetInstance().AddOrder(editingOrder);
			this.Dispose();
		}

		private void CheckOrderIdValidityButton_Click(object sender, EventArgs e)
		{
			string msg = "";
			if (CheckValidity(ref msg)==false)
			{
				MessageBox.Show(msg, "Error");
			}
			else
			{
				MessageBox.Show("OK");
			}
		}

		private bool CheckValidity(ref string msg)
		{
			return CheckOrderIdValidity(ref msg) 
				&& CheckClientNameValidity(ref msg) 
				&& CheckClientPhoneNumberValidity(ref msg);
		}

		private bool CheckOrderIdValidity(ref string msg)
		{
			var idString = editingOrder.Id;
			if (OrderService.GetInstance().FindAll(order => order.Id == idString).Count != 0)
			{
				msg = "Order ID already exists.";
				return false;
			}
			if (idString.Length != 11 || ulong.TryParse(idString, out ulong id) == false)
			{
				msg = "Order ID must consist of exactly 11 digits.";
				return false;
			}
			ulong yyyy = id / 10000000L, MM = id % 10000000L / 100000L, dd = id % 100000L / 1000L;
			bool leap = (yyyy % 400 == 0 || yyyy % 4 == 0 && yyyy % 100 != 0);
			var days = new ulong[] { 0, 31, (ulong)(leap ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (MM < 1 || MM > 12 || dd < 1 || dd > days[MM])
			{
				msg = "Invalid date.";
				return false;
			}
			return true;
		}

		private bool CheckClientNameValidity(ref string msg)
		{
			if (string.IsNullOrEmpty(editingOrder.Client.Name))
			{
				msg = "Client name must not be empty.";
				return false;
			}
			return true;
		}

		private bool CheckClientPhoneNumberValidity(ref string msg)
		{
			if (string.IsNullOrEmpty(editingOrder.Client.PhoneNumber))
			{
				msg = "Phone number must not be empty.";
				return false;
			}
			if (Regex.Match(editingOrder.Client.PhoneNumber, "1[0-9]{10}").Success == false)
			{
				msg = "Phone number must consist of exactly 11 digits starting with '1'.";
				return false;
			}
			return true;
		}
	}
}
