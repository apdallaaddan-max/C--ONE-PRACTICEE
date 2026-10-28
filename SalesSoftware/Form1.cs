using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double NumberOfPackage,PriceOfPackage;
                double DiscountAmount = 0;
                double TotAmount, Total;
                double DiscounTAmountRAte = 0;
                

                //

                NumberOfPackage = double.Parse(txtNumPackage.Text);
                PriceOfPackage = double.Parse(txtPricePackage.Text);
                TotAmount = NumberOfPackage * PriceOfPackage;

                ///

                if (NumberOfPackage <= 0 || PriceOfPackage <= 0)
                {
                    MessageBox.Show("Please Enter Anumber:");
                    return;
                }
                Total = NumberOfPackage * PriceOfPackage;
                /// Calculate The Discount...
                if (NumberOfPackage >= 10 && NumberOfPackage <= 19)
                {
                    DiscountAmount = Total * 0.2;
                    DiscounTAmountRAte = 20;
                }
                else if (NumberOfPackage >= 20 && NumberOfPackage <= 49)
                {
                    DiscountAmount = Total * 0.3;
                    DiscounTAmountRAte = 30;
                }
                else if (NumberOfPackage >= 50 && NumberOfPackage <= 99)
                {
                    DiscountAmount = Total * 0.4;
                    DiscounTAmountRAte = 40;
                }
                else if (NumberOfPackage >= 100)
                {
                    DiscountAmount = Total * 0.5;
                    DiscounTAmountRAte = 50;
                    return;
                }
                // Calculte The Total
                TotAmount = Total - DiscountAmount;
                // output using list box

                lstSoftwareResult.Items.Add("______________________________________________");
                lstSoftwareResult.Items.Add("PURCHASE INFORMATION==");
                lstSoftwareResult.Items.Add("Your Number of Packages Are: " + " " + NumberOfPackage);
                lstSoftwareResult.Items.Add("THe Price Per Package Are:" + " " + PriceOfPackage);
                lstSoftwareResult.Items.Add("Yor Total Amount (before discount):" + " " + Total);
                lstSoftwareResult.Items.Add("Your Discount Rate:" + " " + DiscounTAmountRAte);
                lstSoftwareResult.Items.Add("Your Discount Amount:" +" " +DiscountAmount);
                lstSoftwareResult.Items.Add("Your Total Amount After Discount Is:"+" " + TotAmount);

                lstSoftwareResult.Items.Add("______________________________________________");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Error on Your Code: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstSoftwareResult.Items.Clear();
            txtNumPackage.Text = string.Empty;
            txtPricePackage.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstSoftwareResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 
