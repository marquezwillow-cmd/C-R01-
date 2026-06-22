using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System;
using System.IO;

namespace MarquezP5._0
{
    public partial class SprocketOrderForm : Window
    {
        private SprocketOrder _activeOrder;

        public SprocketOrderForm()
        {
            InitializeComponent();
            _activeOrder = new SprocketOrder();
        }

        //local pickup
        private void ChkLocalPickup_Toggle(object sender, RoutedEventArgs e)
        {
            if (grpAddress == null) return;
            grpAddress.Visibility = (chkLocalPickup.IsChecked == true) ? Visibility.Collapsed : Visibility.Visible;
        }

        //add
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            SprocketForm dialog = new SprocketForm();
            dialog.Owner = this;

            if (dialog.ShowDialog() == true)
            {
                _activeOrder.AddItem(dialog.GeneratedSprocket);
                UpdateUserInterfaceDisplay();
            }
        }

        //remove
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lstSprockets.SelectedItem is Sprocket selectedSprocket)
            {
                MessageBoxResult choice = MessageBox.Show(
                    $"Are you certain you want to delete item ID: {selectedSprocket.ItemID} from this order?",
                    "Confirm Deletion Request",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

                if (choice == MessageBoxResult.Yes)
                {
                    _activeOrder.RemoveItem(selectedSprocket);
                    UpdateUserInterfaceDisplay();
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the center list context block to execute delete commands.", "Selection Validation Required", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        //save
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please fill out the Customer Name value before processing updates.", "Required Customer Identification Details Missing", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _activeOrder.CustomerName = txtCustomerName.Text;

            if (chkLocalPickup.IsChecked == true)
            {
                _activeOrder.ShippingAddress = null;
            }
            else
            {
                _activeOrder.ShippingAddress = new Address
                {
                    Street = txtStreet.Text,
                    City = txtCity.Text,
                    State = txtState.Text,
                    ZipCode = txtZip.Text
                };
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Documents (*.txt)|*.txt";
            saveFileDialog.Title = "Export Order Invoicing Specification Sheet File Data";

            if (saveFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine(_activeOrder.ToString());
                        foreach (var item in _activeOrder.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("Order text manifest recorded successfully!", "Export Configuration Process Finalized", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"File System failure encountered writing output contents to file stream path: {ex.Message}", "Disk Manifest Write Execution Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        //update
        private void UpdateUserInterfaceDisplay()
        {
            lstSprockets.ItemsSource = null;
            lstSprockets.ItemsSource = _activeOrder.Items;
            lblTotalPrice.Text = $"{_activeOrder.TotalPrice:C}";
        }
    }
}