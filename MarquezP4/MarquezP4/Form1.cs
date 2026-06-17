using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MarquezP4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupInstructionTab();
        }

        //tab1
        private void SetupInstructionTab()
        {
            txtInstructions.Text = "Instructions:\r\n" +
                                   "1. Fill out asset properties (Title, Cost, Salvage Value, and Lifetime in Years).\r\n" +
                                   "2. Select the preferred Depreciation Methodology via the radio buttons.\r\n" +
                                   "3. Click 'Add Item to Inventory' to commit the asset into the tracking ledger list.\r\n" +
                                   "4. Double-click any ledger item line to reload its parameters back into the inputs.\r\n" +
                                   "5. Head to the 'Financial Summary' tab and click the button to run the portfolio calculations."; ;
            txtInstructions.ReadOnly = true;
        }

        //tab 2
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. UI Data Validation
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Please enter a valid asset title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtStartValue.Text, out decimal startVal) || startVal < 0)
                {
                    MessageBox.Show("Please enter a valid positive initial acquisition cost ($).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtEndValue.Text, out decimal endVal) || endVal < 0 || endVal > startVal)
                {
                    MessageBox.Show("Salvage value must be positive and cannot exceed the initial asset cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtLifetime.Text, out int lifeYrs) || lifeYrs <= 0)
                {
                    MessageBox.Show("Useful life must be a whole number greater than 0 years.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Polymorphic Object Creation
                DepreciationStraightLine asset;

                if (radDoubleDeclining.Checked)
                {
                    asset = new DepreciationDoubleDeclining();
                }
                else
                {
                    asset = new DepreciationStraightLine();
                }

                // 3. Assign properties (triggers background calculation)
                asset.Title = txtTitle.Text.Trim();
                asset.DateIn = dtpIn.Value;
                asset.DateOut = dtpOut.Value;
                asset.StartValue = startVal;
                asset.EndValue = endVal;
                asset.LifetimeYears = lifeYrs;

                // 4. Add into listbox
                lstInventory.Items.Add(asset);

                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected data entry error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstInventory.SelectedIndex != -1)
            {
                lstInventory.Items.RemoveAt(lstInventory.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item from the ledger list to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // tab 3
        private void ClearInputs()
        {
            txtTitle.Clear();
            txtStartValue.Clear();
            txtEndValue.Clear();
            txtLifetime.Clear();
            dtpIn.Value = DateTime.Now;
            dtpOut.Value = DateTime.Now.AddYears(1);
            radStraightLine.Checked = true;
            txtTitle.Focus();
        }


        private void btnCalculateSummary_Click(object sender, EventArgs e)
        {
            decimal totalInventoryValue = 0;
            int totalCount = lstInventory.Items.Count;

            // Loop through all items in the ListBox 
            foreach (var item in lstInventory.Items)
            {
                if (item is DepreciationStraightLine asset)
                {
                    totalInventoryValue += asset.CurrentDepreciatedValue;
                }
            }

            // Output the calculated figures cleanly into your output TextBoxes
            txtTotalCount.Text = totalCount.ToString();
            txtTotalValue.Text = totalInventoryValue.ToString("C");
        }
    }
}
