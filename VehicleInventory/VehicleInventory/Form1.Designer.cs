namespace VehicleInventory
{
    partial class VehicleInventoryForm
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
            TabControl = new TabControl();
            tbAddVehicle = new TabPage();
            txbResults = new TextBox();
            btnAdd = new Button();
            txbLicense = new TextBox();
            lbLicensePlate = new Label();
            txbVIN = new TextBox();
            lbVIN = new Label();
            cbType = new ComboBox();
            lbVehicleType = new Label();
            tbViewInventory = new TabPage();
            txbSummary = new TextBox();
            lbVehicleSum = new Label();
            lbInventory = new ListBox();
            lbCurrentInventory = new Label();
            TabControl.SuspendLayout();
            tbAddVehicle.SuspendLayout();
            tbViewInventory.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tbAddVehicle);
            TabControl.Controls.Add(tbViewInventory);
            TabControl.Location = new Point(45, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(564, 386);
            TabControl.TabIndex = 0;
            // 
            // tbAddVehicle
            // 
            tbAddVehicle.Controls.Add(txbResults);
            tbAddVehicle.Controls.Add(btnAdd);
            tbAddVehicle.Controls.Add(txbLicense);
            tbAddVehicle.Controls.Add(lbLicensePlate);
            tbAddVehicle.Controls.Add(txbVIN);
            tbAddVehicle.Controls.Add(lbVIN);
            tbAddVehicle.Controls.Add(cbType);
            tbAddVehicle.Controls.Add(lbVehicleType);
            tbAddVehicle.Location = new Point(4, 24);
            tbAddVehicle.Name = "tbAddVehicle";
            tbAddVehicle.Padding = new Padding(3);
            tbAddVehicle.Size = new Size(556, 358);
            tbAddVehicle.TabIndex = 0;
            tbAddVehicle.Text = "Add Vehicle";
            tbAddVehicle.UseVisualStyleBackColor = true;
            // 
            // txbResults
            // 
            txbResults.Location = new Point(-4, 273);
            txbResults.Multiline = true;
            txbResults.Name = "txbResults";
            txbResults.ReadOnly = true;
            txbResults.Size = new Size(564, 89);
            txbResults.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(216, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Vehicle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txbLicense
            // 
            txbLicense.Location = new Point(216, 164);
            txbLicense.Name = "txbLicense";
            txbLicense.Size = new Size(121, 23);
            txbLicense.TabIndex = 5;
            // 
            // lbLicensePlate
            // 
            lbLicensePlate.AutoSize = true;
            lbLicensePlate.Location = new Point(234, 146);
            lbLicensePlate.Name = "lbLicensePlate";
            lbLicensePlate.Size = new Size(78, 15);
            lbLicensePlate.TabIndex = 4;
            lbLicensePlate.Text = "License Plate:";
            // 
            // txbVIN
            // 
            txbVIN.Location = new Point(216, 100);
            txbVIN.Name = "txbVIN";
            txbVIN.Size = new Size(121, 23);
            txbVIN.TabIndex = 3;
            // 
            // lbVIN
            // 
            lbVIN.AutoSize = true;
            lbVIN.Location = new Point(258, 82);
            lbVIN.Name = "lbVIN";
            lbVIN.Size = new Size(32, 15);
            lbVIN.TabIndex = 2;
            lbVIN.Text = "VIN: ";
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Sedan", "Truck" });
            cbType.Location = new Point(216, 43);
            cbType.Name = "cbType";
            cbType.Size = new Size(121, 23);
            cbType.TabIndex = 1;
            // 
            // lbVehicleType
            // 
            lbVehicleType.AutoSize = true;
            lbVehicleType.Location = new Point(234, 25);
            lbVehicleType.Name = "lbVehicleType";
            lbVehicleType.Size = new Size(78, 15);
            lbVehicleType.TabIndex = 0;
            lbVehicleType.Text = "Vehicle Type: ";
            // 
            // tbViewInventory
            // 
            tbViewInventory.Controls.Add(txbSummary);
            tbViewInventory.Controls.Add(lbVehicleSum);
            tbViewInventory.Controls.Add(lbInventory);
            tbViewInventory.Controls.Add(lbCurrentInventory);
            tbViewInventory.Location = new Point(4, 24);
            tbViewInventory.Name = "tbViewInventory";
            tbViewInventory.Padding = new Padding(3);
            tbViewInventory.Size = new Size(556, 358);
            tbViewInventory.TabIndex = 1;
            tbViewInventory.Text = "View Inventory";
            tbViewInventory.UseVisualStyleBackColor = true;
            // 
            // txbSummary
            // 
            txbSummary.Location = new Point(107, 192);
            txbSummary.Multiline = true;
            txbSummary.Name = "txbSummary";
            txbSummary.ReadOnly = true;
            txbSummary.Size = new Size(341, 144);
            txbSummary.TabIndex = 3;
            // 
            // lbVehicleSum
            // 
            lbVehicleSum.AutoSize = true;
            lbVehicleSum.Location = new Point(213, 164);
            lbVehicleSum.Name = "lbVehicleSum";
            lbVehicleSum.Size = new Size(139, 15);
            lbVehicleSum.TabIndex = 2;
            lbVehicleSum.Text = "Vehicle Details Summary:";
            // 
            // lbInventory
            // 
            lbInventory.FormattingEnabled = true;
            lbInventory.ItemHeight = 15;
            lbInventory.Location = new Point(197, 57);
            lbInventory.Name = "lbInventory";
            lbInventory.Size = new Size(171, 94);
            lbInventory.TabIndex = 1;
            lbInventory.MouseDoubleClick += lbInventory_MouseDoubleClick;
            // 
            // lbCurrentInventory
            // 
            lbCurrentInventory.AutoSize = true;
            lbCurrentInventory.Location = new Point(232, 29);
            lbCurrentInventory.Name = "lbCurrentInventory";
            lbCurrentInventory.Size = new Size(100, 15);
            lbCurrentInventory.TabIndex = 0;
            lbCurrentInventory.Text = "Current Inventory";
            // 
            // VehicleInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControl);
            Name = "VehicleInventoryForm";
            Text = "Form1";
            TabControl.ResumeLayout(false);
            tbAddVehicle.ResumeLayout(false);
            tbAddVehicle.PerformLayout();
            tbViewInventory.ResumeLayout(false);
            tbViewInventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tbAddVehicle;
        private TabPage tbViewInventory;
        private ComboBox cbType;
        private Label lbVehicleType;
        private TextBox txbResults;
        private Button btnAdd;
        private TextBox txbLicense;
        private Label lbLicensePlate;
        private TextBox txbVIN;
        private Label lbVIN;
        private TextBox txbSummary;
        private Label lbVehicleSum;
        private ListBox lbInventory;
        private Label lbCurrentInventory;
    }
}
