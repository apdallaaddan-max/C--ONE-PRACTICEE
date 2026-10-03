using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRangeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                try
                {
                    double number;

                    if (txtRange.Text == "")
                    {
                        MessageBox.Show("Please enter a number.");
                    }
                    else
                    {
                        number = double.Parse(txtRange.Text);

                        if (number >= 1 && number <= 10)
                        {
                            lblDecisionOutPut.Text = "This number is in the range of 1 to 10.";
                        }
                        else
                        {
                            lblDecisionOutPut.Text = "This number is outside of the range of 1 to 10.";
                        }
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtRange.Clear();
            this.lblDecisionOutPut.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
