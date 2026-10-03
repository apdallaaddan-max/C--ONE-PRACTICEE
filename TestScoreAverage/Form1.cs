using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestScoreAverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double score1, score2, score3, average;

                score1 = double.Parse(txtscore1.Text);
                score2 = double.Parse(txtScore2.Text);
                score3 = double.Parse(txtscore3.Text);

                average = (score1 + score2 + score3) / 3;
                if (average >= 90)
                {
                    lbloutput.Text = average.ToString("0.0") + "Excellent: ";
                }
                else if (average >= 80)
                {
                    lbloutput.Text =   average.ToString("0.0")+ "Very Good: ";
                }
                else if (average >= 70)
                {
                    lbloutput.Text =average.ToString("0.0") + "Good: ";
                }
                else if (average >= 60)
                {
                    lbloutput.Text = average.ToString("0.0") + " Pass";
                }
                else
                {
                    lbloutput.Text =   average.ToString("0.0") + " Fail";
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtscore1.Clear();
            this.txtScore2.Clear();
            this.txtscore3.Clear();
            this.lbloutput.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
