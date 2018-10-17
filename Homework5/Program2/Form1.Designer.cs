namespace Program2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ClearAndDrawCheckBox = new System.Windows.Forms.CheckBox();
            this.DrawButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KOffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.Th1OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.Th2OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.Per2OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.Per1OffsetTrackBar = new System.Windows.Forms.TrackBar();
            this.TreeDepthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RandomlyGenerateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KOffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th1OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th2OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Per2OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Per1OffsetTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeDepthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearAndDrawCheckBox
            // 
            this.ClearAndDrawCheckBox.AutoSize = true;
            this.ClearAndDrawCheckBox.Location = new System.Drawing.Point(853, 75);
            this.ClearAndDrawCheckBox.Name = "ClearAndDrawCheckBox";
            this.ClearAndDrawCheckBox.Size = new System.Drawing.Size(125, 21);
            this.ClearAndDrawCheckBox.TabIndex = 7;
            this.ClearAndDrawCheckBox.Text = "Clear and draw";
            this.ClearAndDrawCheckBox.UseVisualStyleBackColor = true;
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(853, 12);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(121, 25);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.Draw_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(853, 43);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(121, 25);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.AllowDrop = true;
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue",
            "Green"});
            this.ColorComboBox.Location = new System.Drawing.Point(853, 120);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 24);
            this.ColorComboBox.TabIndex = 2;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(853, 179);
            this.WidthNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.WidthNumericUpDown.TabIndex = 3;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // KOffsetTrackBar
            // 
            this.KOffsetTrackBar.Location = new System.Drawing.Point(853, 233);
            this.KOffsetTrackBar.Maximum = 200;
            this.KOffsetTrackBar.Minimum = 1;
            this.KOffsetTrackBar.Name = "KOffsetTrackBar";
            this.KOffsetTrackBar.Size = new System.Drawing.Size(116, 56);
            this.KOffsetTrackBar.TabIndex = 4;
            this.KOffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.KOffsetTrackBar.Value = 1;
            // 
            // Th1OffsetTrackBar
            // 
            this.Th1OffsetTrackBar.Location = new System.Drawing.Point(853, 286);
            this.Th1OffsetTrackBar.Maximum = 360;
            this.Th1OffsetTrackBar.Minimum = 1;
            this.Th1OffsetTrackBar.Name = "Th1OffsetTrackBar";
            this.Th1OffsetTrackBar.Size = new System.Drawing.Size(116, 56);
            this.Th1OffsetTrackBar.TabIndex = 5;
            this.Th1OffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Th1OffsetTrackBar.Value = 1;
            // 
            // Th2OffsetTrackBar
            // 
            this.Th2OffsetTrackBar.Location = new System.Drawing.Point(853, 315);
            this.Th2OffsetTrackBar.Maximum = 360;
            this.Th2OffsetTrackBar.Name = "Th2OffsetTrackBar";
            this.Th2OffsetTrackBar.Size = new System.Drawing.Size(116, 56);
            this.Th2OffsetTrackBar.TabIndex = 6;
            this.Th2OffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Per2OffsetTrackBar
            // 
            this.Per2OffsetTrackBar.Location = new System.Drawing.Point(853, 403);
            this.Per2OffsetTrackBar.Minimum = 1;
            this.Per2OffsetTrackBar.Name = "Per2OffsetTrackBar";
            this.Per2OffsetTrackBar.Size = new System.Drawing.Size(116, 56);
            this.Per2OffsetTrackBar.TabIndex = 9;
            this.Per2OffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Per2OffsetTrackBar.Value = 1;
            // 
            // Per1OffsetTrackBar
            // 
            this.Per1OffsetTrackBar.Location = new System.Drawing.Point(853, 374);
            this.Per1OffsetTrackBar.Minimum = 1;
            this.Per1OffsetTrackBar.Name = "Per1OffsetTrackBar";
            this.Per1OffsetTrackBar.Size = new System.Drawing.Size(116, 56);
            this.Per1OffsetTrackBar.TabIndex = 8;
            this.Per1OffsetTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Per1OffsetTrackBar.Value = 1;
            // 
            // TreeDepthNumericUpDown
            // 
            this.TreeDepthNumericUpDown.Location = new System.Drawing.Point(853, 466);
            this.TreeDepthNumericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.TreeDepthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TreeDepthNumericUpDown.Name = "TreeDepthNumericUpDown";
            this.TreeDepthNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.TreeDepthNumericUpDown.TabIndex = 10;
            this.TreeDepthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(822, 591);
            this.DrawingPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(853, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pen width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Children offset:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Separated offset:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(853, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Children lengths:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(853, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tree depth:";
            // 
            // RandomlyGenerateButton
            // 
            this.RandomlyGenerateButton.Location = new System.Drawing.Point(853, 561);
            this.RandomlyGenerateButton.Name = "RandomlyGenerateButton";
            this.RandomlyGenerateButton.Size = new System.Drawing.Size(121, 42);
            this.RandomlyGenerateButton.TabIndex = 13;
            this.RandomlyGenerateButton.Text = "Randomly Generate";
            this.RandomlyGenerateButton.UseVisualStyleBackColor = true;
            this.RandomlyGenerateButton.Click += new System.EventHandler(this.RandomlyGenerateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 615);
            this.Controls.Add(this.RandomlyGenerateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.TreeDepthNumericUpDown);
            this.Controls.Add(this.Per2OffsetTrackBar);
            this.Controls.Add(this.Per1OffsetTrackBar);
            this.Controls.Add(this.ClearAndDrawCheckBox);
            this.Controls.Add(this.Th2OffsetTrackBar);
            this.Controls.Add(this.Th1OffsetTrackBar);
            this.Controls.Add(this.KOffsetTrackBar);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KOffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th1OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th2OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Per2OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Per1OffsetTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreeDepthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.TrackBar KOffsetTrackBar;
        private System.Windows.Forms.TrackBar Th1OffsetTrackBar;
        private System.Windows.Forms.TrackBar Th2OffsetTrackBar;
        private System.Windows.Forms.CheckBox ClearAndDrawCheckBox;
        private System.Windows.Forms.TrackBar Per2OffsetTrackBar;
        private System.Windows.Forms.TrackBar Per1OffsetTrackBar;
        private System.Windows.Forms.NumericUpDown TreeDepthNumericUpDown;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RandomlyGenerateButton;
    }
}

