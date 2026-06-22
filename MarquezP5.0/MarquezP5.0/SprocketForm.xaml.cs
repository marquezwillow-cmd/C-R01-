using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MarquezP5._0
{
    public partial class SprocketForm : Window
    {
        public Sprocket GeneratedSprocket { get; private set; }

        public SprocketForm()
        {
            InitializeComponent();
        }

        //submit
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemId.Text) ||
                cmbMaterial.SelectedIndex == -1 ||
                !int.TryParse(txtTeeth.Text, out int teeth) ||
                !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please ensure all inputs are complete. Items/Teeth counts must be non-negative whole numbers.", "Data Entry Validation Failure", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                string id = txtItemId.Text;
                string material = (cmbMaterial.SelectedItem as ComboBoxItem).Content.ToString();

                switch (material)
                {
                    case "Steel":
                        GeneratedSprocket = new SteelSprocket(id, quantity, teeth);
                        break;
                    case "Aluminum":
                        GeneratedSprocket = new AluminumSprocket(id, quantity, teeth);
                        break;
                    case "Plastic":
                        GeneratedSprocket = new PlasticSprocket(id, quantity, teeth);
                        break;
                }

                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Runtime Calculation Core Exception", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //cancel
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
