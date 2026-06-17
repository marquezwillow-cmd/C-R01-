namespace MarquezP4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabInstructions = new TabPage();
            txtInstructions = new TextBox();
            tabInventory = new TabPage();
            lstInventory = new ListBox();
            btnRemove = new Button();
            btnAdd = new Button();
            radStraightLine = new RadioButton();
            radDoubleDeclining = new RadioButton();
            txtLifetime = new TextBox();
            txtEndValue = new TextBox();
            txtStartValue = new TextBox();
            dtpOut = new DateTimePicker();
            dtpIn = new DateTimePicker();
            txtTitle = new TextBox();
            lblLedgerHeader = new Label();
            lblMethod = new Label();
            lblLifetime = new Label();
            lblEndValue = new Label();
            lblStartValue = new Label();
            lblDateOut = new Label();
            lblDateIn = new Label();
            lblTitle = new Label();
            tabSummary = new TabPage();
            txtTotalValue = new TextBox();
            lblTotalValue = new Label();
            txtTotalCount = new TextBox();
            btnCalculateSummary = new Button();
            lblAssetCount = new Label();
            tabControl1.SuspendLayout();
            tabInstructions.SuspendLayout();
            tabInventory.SuspendLayout();
            tabSummary.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInstructions);
            tabControl1.Controls.Add(tabInventory);
            tabControl1.Controls.Add(tabSummary);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 616);
            tabControl1.TabIndex = 0;
            // 
            // tabInstructions
            // 
            tabInstructions.Controls.Add(txtInstructions);
            tabInstructions.Location = new Point(4, 24);
            tabInstructions.Name = "tabInstructions";
            tabInstructions.Padding = new Padding(3);
            tabInstructions.Size = new Size(872, 588);
            tabInstructions.TabIndex = 0;
            tabInstructions.Text = "Instructions";
            tabInstructions.UseVisualStyleBackColor = true;
            // 
            // txtInstructions
            // 
            txtInstructions.Dock = DockStyle.Fill;
            txtInstructions.Location = new Point(3, 3);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.ReadOnly = true;
            txtInstructions.ScrollBars = ScrollBars.Vertical;
            txtInstructions.Size = new Size(866, 582);
            txtInstructions.TabIndex = 0;
            // 
            // tabInventory
            // 
            tabInventory.Controls.Add(lstInventory);
            tabInventory.Controls.Add(btnRemove);
            tabInventory.Controls.Add(btnAdd);
            tabInventory.Controls.Add(radStraightLine);
            tabInventory.Controls.Add(radDoubleDeclining);
            tabInventory.Controls.Add(txtLifetime);
            tabInventory.Controls.Add(txtEndValue);
            tabInventory.Controls.Add(txtStartValue);
            tabInventory.Controls.Add(dtpOut);
            tabInventory.Controls.Add(dtpIn);
            tabInventory.Controls.Add(txtTitle);
            tabInventory.Controls.Add(lblLedgerHeader);
            tabInventory.Controls.Add(lblMethod);
            tabInventory.Controls.Add(lblLifetime);
            tabInventory.Controls.Add(lblEndValue);
            tabInventory.Controls.Add(lblStartValue);
            tabInventory.Controls.Add(lblDateOut);
            tabInventory.Controls.Add(lblDateIn);
            tabInventory.Controls.Add(lblTitle);
            tabInventory.Location = new Point(4, 24);
            tabInventory.Name = "tabInventory";
            tabInventory.Padding = new Padding(3);
            tabInventory.Size = new Size(872, 588);
            tabInventory.TabIndex = 1;
            tabInventory.Text = "Inventory";
            tabInventory.UseVisualStyleBackColor = true;
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.ItemHeight = 15;
            lstInventory.Location = new Point(273, 454);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(336, 109);
            lstInventory.TabIndex = 18;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(348, 416);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(200, 23);
            btnRemove.TabIndex = 17;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(348, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 28);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Item to Inventory";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // radStraightLine
            // 
            radStraightLine.AutoSize = true;
            radStraightLine.Checked = true;
            radStraightLine.Location = new Point(365, 305);
            radStraightLine.Name = "radStraightLine";
            radStraightLine.Size = new Size(161, 19);
            radStraightLine.TabIndex = 15;
            radStraightLine.TabStop = true;
            radStraightLine.Text = "Straight Line Depreciation";
            radStraightLine.UseVisualStyleBackColor = true;
            // 
            // radDoubleDeclining
            // 
            radDoubleDeclining.AutoSize = true;
            radDoubleDeclining.Location = new Point(365, 330);
            radDoubleDeclining.Name = "radDoubleDeclining";
            radDoubleDeclining.Size = new Size(186, 19);
            radDoubleDeclining.TabIndex = 14;
            radDoubleDeclining.Text = "Double Declining Depreciation";
            radDoubleDeclining.UseVisualStyleBackColor = true;
            // 
            // txtLifetime
            // 
            txtLifetime.Location = new Point(348, 249);
            txtLifetime.Name = "txtLifetime";
            txtLifetime.Size = new Size(200, 23);
            txtLifetime.TabIndex = 13;
            // 
            // txtEndValue
            // 
            txtEndValue.Location = new Point(348, 194);
            txtEndValue.Name = "txtEndValue";
            txtEndValue.Size = new Size(200, 23);
            txtEndValue.TabIndex = 12;
            // 
            // txtStartValue
            // 
            txtStartValue.Location = new Point(348, 139);
            txtStartValue.Name = "txtStartValue";
            txtStartValue.Size = new Size(200, 23);
            txtStartValue.TabIndex = 11;
            // 
            // dtpOut
            // 
            dtpOut.Location = new Point(348, 85);
            dtpOut.Name = "dtpOut";
            dtpOut.Size = new Size(200, 23);
            dtpOut.TabIndex = 10;
            // 
            // dtpIn
            // 
            dtpIn.Location = new Point(348, 56);
            dtpIn.Name = "dtpIn";
            dtpIn.Size = new Size(200, 23);
            dtpIn.TabIndex = 9;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(312, 18);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(297, 23);
            txtTitle.TabIndex = 8;
            // 
            // lblLedgerHeader
            // 
            lblLedgerHeader.AutoSize = true;
            lblLedgerHeader.Location = new Point(383, 454);
            lblLedgerHeader.Name = "lblLedgerHeader";
            lblLedgerHeader.Size = new Size(0, 15);
            lblLedgerHeader.TabIndex = 7;
            // 
            // lblMethod
            // 
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(409, 287);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(77, 15);
            lblMethod.TabIndex = 6;
            lblMethod.Text = "Depreciation:";
            // 
            // lblLifetime
            // 
            lblLifetime.AutoSize = true;
            lblLifetime.Location = new Point(418, 231);
            lblLifetime.Name = "lblLifetime";
            lblLifetime.Size = new Size(59, 15);
            lblLifetime.TabIndex = 5;
            lblLifetime.Text = "Life Time:";
            // 
            // lblEndValue
            // 
            lblEndValue.AutoSize = true;
            lblEndValue.Location = new Point(418, 176);
            lblEndValue.Name = "lblEndValue";
            lblEndValue.Size = new Size(61, 15);
            lblEndValue.TabIndex = 4;
            lblEndValue.Text = "End Value:";
            // 
            // lblStartValue
            // 
            lblStartValue.AutoSize = true;
            lblStartValue.Location = new Point(409, 121);
            lblStartValue.Name = "lblStartValue";
            lblStartValue.Size = new Size(70, 15);
            lblStartValue.TabIndex = 3;
            lblStartValue.Text = "Initial Value:";
            // 
            // lblDateOut
            // 
            lblDateOut.AutoSize = true;
            lblDateOut.Location = new Point(283, 91);
            lblDateOut.Name = "lblDateOut";
            lblDateOut.Size = new Size(57, 15);
            lblDateOut.TabIndex = 2;
            lblDateOut.Text = "Date Out:";
            // 
            // lblDateIn
            // 
            lblDateIn.AutoSize = true;
            lblDateIn.Location = new Point(283, 62);
            lblDateIn.Name = "lblDateIn";
            lblDateIn.Size = new Size(47, 15);
            lblDateIn.TabIndex = 1;
            lblDateIn.Text = "Date In:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(273, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(33, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // tabSummary
            // 
            tabSummary.Controls.Add(txtTotalValue);
            tabSummary.Controls.Add(lblTotalValue);
            tabSummary.Controls.Add(txtTotalCount);
            tabSummary.Controls.Add(btnCalculateSummary);
            tabSummary.Controls.Add(lblAssetCount);
            tabSummary.Location = new Point(4, 24);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new Padding(3);
            tabSummary.Size = new Size(872, 588);
            tabSummary.TabIndex = 2;
            tabSummary.Text = "Financial Summary";
            tabSummary.UseVisualStyleBackColor = true;
            // 
            // txtTotalValue
            // 
            txtTotalValue.Location = new Point(394, 138);
            txtTotalValue.Name = "txtTotalValue";
            txtTotalValue.ReadOnly = true;
            txtTotalValue.Size = new Size(199, 23);
            txtTotalValue.TabIndex = 4;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(255, 141);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(137, 15);
            lblTotalValue.TabIndex = 3;
            lblTotalValue.Text = "Combined Ending Value:";
            // 
            // txtTotalCount
            // 
            txtTotalCount.Location = new Point(333, 98);
            txtTotalCount.Name = "txtTotalCount";
            txtTotalCount.ReadOnly = true;
            txtTotalCount.Size = new Size(260, 23);
            txtTotalCount.TabIndex = 2;
            // 
            // btnCalculateSummary
            // 
            btnCalculateSummary.Location = new Point(240, 47);
            btnCalculateSummary.Name = "btnCalculateSummary";
            btnCalculateSummary.Size = new Size(353, 22);
            btnCalculateSummary.TabIndex = 1;
            btnCalculateSummary.Text = "Run Portfolio Valuation Balance Summary";
            btnCalculateSummary.UseVisualStyleBackColor = true;
            btnCalculateSummary.Click += btnCalculateSummary_Click;
            // 
            // lblAssetCount
            // 
            lblAssetCount.AutoSize = true;
            lblAssetCount.Location = new Point(255, 101);
            lblAssetCount.Name = "lblAssetCount";
            lblAssetCount.Size = new Size(72, 15);
            lblAssetCount.TabIndex = 0;
            lblAssetCount.Text = "Total Assets:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 616);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabInstructions.ResumeLayout(false);
            tabInstructions.PerformLayout();
            tabInventory.ResumeLayout(false);
            tabInventory.PerformLayout();
            tabSummary.ResumeLayout(false);
            tabSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabInstructions;
        private TabPage tabInventory;
        private TabPage tabSummary;
        private TextBox txtInstructions;
        private TextBox txtTitle;
        private Label lblLedgerHeader;
        private Label lblMethod;
        private Label lblLifetime;
        private Label lblEndValue;
        private Label lblStartValue;
        private Label lblDateOut;
        private Label lblDateIn;
        private Label lblTitle;
        private TextBox txtStartValue;
        private DateTimePicker dtpOut;
        private DateTimePicker dtpIn;
        private RadioButton radDoubleDeclining;
        private TextBox txtLifetime;
        private TextBox txtEndValue;
        private RadioButton radStraightLine;
        private ListBox lstInventory;
        private Button btnRemove;
        private Button btnAdd;
        private Button btnCalculateSummary;
        private Label lblAssetCount;
        private TextBox txtTotalValue;
        private Label lblTotalValue;
        private TextBox txtTotalCount;
    }
}
