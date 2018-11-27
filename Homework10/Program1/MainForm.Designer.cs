namespace Program1
{
	partial class MainForm
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.orderDataGridView = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.addOrderButton = new System.Windows.Forms.Button();
			this.removeOrderButton = new System.Windows.Forms.Button();
			this.modifyOrderButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.clientNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.costFromTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.costToTextBox = new System.Windows.Forms.TextBox();
			this.findOrderButton = new System.Windows.Forms.Button();
			this.resetOrderButton = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuStrip.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Location = new System.Drawing.Point(0, 531);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(782, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip";
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(782, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.saveAsHTMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Enabled = false;
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Enabled = false;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
			// 
			// saveAsHTMLToolStripMenuItem
			// 
			this.saveAsHTMLToolStripMenuItem.Name = "saveAsHTMLToolStripMenuItem";
			this.saveAsHTMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsHTMLToolStripMenuItem.Text = "Save As HTML";
			this.saveAsHTMLToolStripMenuItem.Click += new System.EventHandler(this.SaveAsHTMLToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.orderDataGridView);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(589, 507);
			this.panel1.TabIndex = 2;
			// 
			// orderDataGridView
			// 
			this.orderDataGridView.AllowUserToAddRows = false;
			this.orderDataGridView.AllowUserToDeleteRows = false;
			this.orderDataGridView.AllowUserToOrderColumns = true;
			this.orderDataGridView.AutoGenerateColumns = false;
			this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Client,
            this.costDataGridViewTextBoxColumn});
			this.orderDataGridView.DataSource = this.orderBindingSource;
			this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderDataGridView.Location = new System.Drawing.Point(0, 0);
			this.orderDataGridView.Name = "orderDataGridView";
			this.orderDataGridView.ReadOnly = true;
			this.orderDataGridView.RowTemplate.Height = 24;
			this.orderDataGridView.Size = new System.Drawing.Size(589, 507);
			this.orderDataGridView.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tableLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(589, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(193, 507);
			this.panel2.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 507);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.addOrderButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.removeOrderButton, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.modifyOrderButton, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.clientNameTextBox, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.costFromTextBox, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 9);
			this.tableLayoutPanel2.Controls.Add(this.costToTextBox, 0, 10);
			this.tableLayoutPanel2.Controls.Add(this.findOrderButton, 0, 11);
			this.tableLayoutPanel2.Controls.Add(this.resetOrderButton, 0, 12);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 13;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(187, 501);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// addOrderButton
			// 
			this.addOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addOrderButton.Location = new System.Drawing.Point(3, 3);
			this.addOrderButton.Name = "addOrderButton";
			this.addOrderButton.Size = new System.Drawing.Size(181, 30);
			this.addOrderButton.TabIndex = 0;
			this.addOrderButton.Text = "Add Order";
			this.addOrderButton.UseVisualStyleBackColor = true;
			this.addOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
			// 
			// removeOrderButton
			// 
			this.removeOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.removeOrderButton.Location = new System.Drawing.Point(3, 39);
			this.removeOrderButton.Name = "removeOrderButton";
			this.removeOrderButton.Size = new System.Drawing.Size(181, 30);
			this.removeOrderButton.TabIndex = 1;
			this.removeOrderButton.Text = "Remove Order";
			this.removeOrderButton.UseVisualStyleBackColor = true;
			this.removeOrderButton.Click += new System.EventHandler(this.RemoveOrderButton_Click);
			// 
			// modifyOrderButton
			// 
			this.modifyOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modifyOrderButton.Location = new System.Drawing.Point(3, 75);
			this.modifyOrderButton.Name = "modifyOrderButton";
			this.modifyOrderButton.Size = new System.Drawing.Size(181, 30);
			this.modifyOrderButton.TabIndex = 2;
			this.modifyOrderButton.Text = "Modify Order";
			this.modifyOrderButton.UseVisualStyleBackColor = true;
			this.modifyOrderButton.Click += new System.EventHandler(this.ModifyOrderButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 108);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Search Filter:\r\n(Leave empty to ignore.)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Client Name:";
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clientNameTextBox.Location = new System.Drawing.Point(3, 150);
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.Size = new System.Drawing.Size(181, 20);
			this.clientNameTextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Cost Range:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "From: (inclusive)";
			// 
			// costFromTextBox
			// 
			this.costFromTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.costFromTextBox.Location = new System.Drawing.Point(3, 209);
			this.costFromTextBox.Name = "costFromTextBox";
			this.costFromTextBox.Size = new System.Drawing.Size(181, 20);
			this.costFromTextBox.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "To: (exclusive)";
			// 
			// costToTextBox
			// 
			this.costToTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.costToTextBox.Location = new System.Drawing.Point(3, 255);
			this.costToTextBox.Name = "costToTextBox";
			this.costToTextBox.Size = new System.Drawing.Size(181, 20);
			this.costToTextBox.TabIndex = 10;
			// 
			// findOrderButton
			// 
			this.findOrderButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.findOrderButton.Location = new System.Drawing.Point(3, 281);
			this.findOrderButton.Name = "findOrderButton";
			this.findOrderButton.Size = new System.Drawing.Size(181, 30);
			this.findOrderButton.TabIndex = 11;
			this.findOrderButton.Text = "Find Order";
			this.findOrderButton.UseVisualStyleBackColor = true;
			this.findOrderButton.Click += new System.EventHandler(this.FindOrderButton_Click);
			// 
			// resetOrderButton
			// 
			this.resetOrderButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.resetOrderButton.Location = new System.Drawing.Point(3, 317);
			this.resetOrderButton.Name = "resetOrderButton";
			this.resetOrderButton.Size = new System.Drawing.Size(181, 30);
			this.resetOrderButton.TabIndex = 12;
			this.resetOrderButton.Text = "Reset Orders";
			this.resetOrderButton.UseVisualStyleBackColor = true;
			this.resetOrderButton.Click += new System.EventHandler(this.ResetOrderButton_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn1.HeaderText = "Client";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn2.HeaderText = "Client";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn3.HeaderText = "Client";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn4.HeaderText = "Client";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn5.HeaderText = "Client";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn6.HeaderText = "Client";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn7.HeaderText = "Client";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn8.HeaderText = "Client";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Enabled = false;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Enabled = false;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Client";
			this.dataGridViewTextBoxColumn9.HeaderText = "Client";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Client
			// 
			this.Client.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Client.DataPropertyName = "Client";
			this.Client.HeaderText = "Client";
			this.Client.Name = "Client";
			this.Client.ReadOnly = true;
			// 
			// costDataGridViewTextBoxColumn
			// 
			this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
			this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
			this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
			this.costDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(Program1.Order);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "MainForm";
			this.Text = "Order Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView orderDataGridView;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button addOrderButton;
		private System.Windows.Forms.Button removeOrderButton;
		private System.Windows.Forms.Button modifyOrderButton;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox clientNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox costFromTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox costToTextBox;
		private System.Windows.Forms.Button findOrderButton;
		private System.Windows.Forms.Button resetOrderButton;
		private System.Windows.Forms.ToolStripMenuItem saveAsHTMLToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Client;
		private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
	}
}

