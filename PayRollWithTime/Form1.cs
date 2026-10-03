using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRollWithTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double hoursWorked, hourlyPayrate, grossPay;
                // Check validation
                if (txtHoursWorked.Text == "")
                {
                    MessageBox.Show("Please enter hours worked.");
                }
                else
                {
                    if (txtHourlypayrate.Text == "")
                    {
                        MessageBox.Show("Please enter hourly pay rate.");
                    }
                    else
                    {
                        hoursWorked = double.Parse(txtHoursWorked.Text);
                        hourlyPayrate = double.Parse(txtHourlypayrate.Text);

                        // Check negative values
                        if (hoursWorked < 0 || hourlyPayrate < 0)
                        {
                            MessageBox.Show("Please enter positive numbers.");
                        }
                        else
                        {
                            // Overtime calculation
                            if (hoursWorked <= 40)
                            {
                                grossPay = hoursWorked * hourlyPayrate;
                            }
                            else
                            {
                                grossPay = (40 * hourlyPayrate) +
                                           ((hoursWorked - 40) * hourlyPayrate * 1.5);
                            }
                            lblGrossPayLabel.Text = grossPay.ToString("C2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnClearButton_Click(object sender, EventArgs e)
        {
           txtHourlypayrate.Clear();
           txtHoursWorked.Clear();
           lblGrossPayLabel.Text = "";
        }

        private void btnExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
