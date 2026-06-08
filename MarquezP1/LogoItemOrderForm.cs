using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarquezP1
{
    public partial class LogoItemOrderForm : Form
    {
        public LogoItemOrderForm()
        {
            InitializeComponent();

            lblColors.Visible = false;
            txtColors.Visible = false;
        }
        private void chkLogo_CheckedChanged(object sender, EventArgs e)
        {
            lblColors.Visible = chkLogo.Checked;
            txtColors.Visible = chkLogo.Checked;
        }

        //submit buttion
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LogoOrderItem order =
                    new LogoOrderItem(txtText.Text, chkLogo.Checked);

                order.ItemID = int.Parse(txtOrderNumber.Text);
                order.NumItems = int.Parse(txtNumItems.Text);

                if (radPen.Checked)
                    order.ItemType = "pen";
                else if (radMug.Checked)
                    order.ItemType = "mug";
                else if (radUsb.Checked)
                    order.ItemType = "usb";

                // SAFE PARSING (prevents crash)
                if (chkLogo.Checked)
                {
                    if (!int.TryParse(txtColors.Text, out int colors))
                    {
                        txtResults.Text = "Enter a valid number for colors.";
                        return;
                    }
                    order.NumColors = colors;
                }
                else
                {
                    order.NumColors = 0;
                }

                txtResults.Text = order.GetOrderSummary();
            }
            catch (Exception ex)
            {
                txtResults.Text = ex.Message;
            }
        }
        //clear form 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Clear();
            txtNumItems.Clear();
            txtText.Clear();
            txtColors.Clear();
            txtResults.Clear();

            chkLogo.Checked = false;
            radMug.Checked = true;

            lblColors.Visible = false;
            txtColors.Visible = false;
        }
    }
}