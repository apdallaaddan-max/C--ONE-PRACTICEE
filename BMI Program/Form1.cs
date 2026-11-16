using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Weight, height;
            double calculate;

            try
            {
                if (double.TryParse(txtWeight.Text, out Weight) & double.TryParse(txtHeight.Text,out height)) 
                {

                    Weight=double.Parse(txtWeight.Text);
                    height = double.Parse(txtHeight.Text);
                    calculate = Weight * 703 / (height * height);
                    double result = calculate;


                    //
                    if (Weight < 18.5)
                    {
                        lstResult.Items.Add(result + " kg");
                        lstResult.Items.Add("Under Weight");

                    }
                    else if (Weight >= 18.5 && Weight <= 25)
                    {
                        lstResult.Items.Add(result + " kg");
                        lstResult.Items.Add("Optimal Weight");
                    }
                    else if (Weight > 25)
                    {
                        lstResult.Items.Add(result + " kg");
                        lstResult.Items.Add("Over Weight");
                    }
                    else
                    {
                        MessageBox.Show("ENter WEight");
                    }
                }

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is Error on Your Code: " + ex.Message);
            }
        }
    }
}
