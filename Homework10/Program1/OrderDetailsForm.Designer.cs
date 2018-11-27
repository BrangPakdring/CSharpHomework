namespace Program1
{
	partial class OrderDetailsForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.orderIdTextBox = new System.Windows.Forms.TextBox();
			this.costLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.clientTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.checkOrderIdValidityButton = new System.Windows.Forms.Button();
			this.confirmButton = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 136);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.49051F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.49052F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.49052F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.52845F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.confirmButton, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 121);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.orderIdTextBox);
			this.panel2.Controls.Add(this.costLabel);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(216, 115);
			this.panel2.TabIndex = 0;
			// 
			// orderIdTextBox
			// 
			this.orderIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.orderIdTextBox.Location = new System.Drawing.Point(2, 24);
			this.orderIdTextBox.Name = "orderIdTextBox";
			this.orderIdTextBox.Size = new System.Drawing.Size(212, 26);
			this.orderIdTextBox.TabIndex = 3;
			// 
			// costLabel
			// 
			this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.costLabel.Location = new System.Drawing.Point(-2, 76);
			this.costLabel.Name = "costLabel";
			this.costLabel.Size = new System.Drawing.Size(216, 39);
			this.costLabel.TabIndex = 3;
			this.costLabel.Text = "0";
			this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Order ID:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cost:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.phoneTextBox);
			this.panel3.Controls.Add(this.clientTextBox);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(225, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(216, 115);
			this.panel3.TabIndex = 1;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.phoneTextBox.Location = new System.Drawing.Point(1, 83);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(212, 26);
			this.phoneTextBox.TabIndex = 3;
			// 
			// clientTextBox
			// 
			this.clientTextBox.AcceptsReturn = true;
			this.clientTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.clientTextBox.Location = new System.Drawing.Point(0, 23);
			this.clientTextBox.Name = "clientTextBox";
			this.clientTextBox.Size = new System.Drawing.Size(216, 26);
			this.clientTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(216, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Client Phone:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(216, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Client Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.checkOrderIdValidityButton);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(447, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(216, 115);
			this.panel4.TabIndex = 2;
			// 
			// checkOrderIdValidityButton
			// 
			this.checkOrderIdValidityButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkOrderIdValidityButton.Location = new System.Drawing.Point(0, 0);
			this.checkOrderIdValidityButton.Name = "checkOrderIdValidityButton";
			this.checkOrderIdValidityButton.Size = new System.Drawing.Size(216, 115);
			this.checkOrderIdValidityButton.TabIndex = 4;
			this.checkOrderIdValidityButton.Text = "Check Validity";
			this.checkOrderIdValidityButton.UseVisualStyleBackColor = true;
			this.checkOrderIdValidityButton.Click += new System.EventHandler(this.CheckOrderIdValidityButton_Click);
			// 
			// confirmButton
			// 
			this.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.confirmButton.Location = new System.Drawing.Point(669, 3);
			this.confirmButton.Name = "confirmButton";
			this.confirmButton.Size = new System.Drawing.Size(110, 115);
			this.confirmButton.TabIndex = 3;
			this.confirmButton.Text = "Confirm";
			this.confirmButton.UseVisualStyleBackColor = true;
			this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel7);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 176);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(784, 385);
			this.panel5.TabIndex = 1;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.dataGridView1);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(784, 385);
			this.panel7.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costDataGridViewTextBoxColumn,
            this.Count,
            this.ProductPrice,
            this.ProductName});
			this.dataGridView1.DataSource = this.orderDetailsBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(784, 385);
			this.dataGridView1.TabIndex = 0;
			// 
			// costDataGridViewTextBoxColumn
			// 
			this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
			this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
			this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
			this.costDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "Count";
			this.Count.Name = "Count";
			// 
			// ProductPrice
			// 
			this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProductPrice.DataPropertyName = "ProductPrice";
			this.ProductPrice.HeaderText = "Product Price";
			this.ProductPrice.Name = "ProductPrice";
			// 
			// ProductName
			// 
			this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "Product Name";
			this.ProductName.Name = "ProductName";
			// 
			// orderDetailsBindingSource
			// 
			this.orderDetailsBindingSource.DataMember = "List";
			this.orderDetailsBindingSource.DataSource = this.orderBindingSource;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(Program1.Order);
			// 
			// OrderDetailsForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "OrderDetailsForm";
			this.Text = "Order Details";
			this.Load += new System.EventHandler(this.AddOrderForm_Load);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox clientTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label costLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource orderDetailsBindingSource;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.Button confirmButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.Button checkOrderIdValidityButton;
		private System.Windows.Forms.TextBox orderIdTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label label4;
	}
}