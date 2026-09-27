using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {

                // Stage 1 creating variables
                int x, y, z;

                //initial Values To variables
                x = int.Parse(txt1stnum.Text);
                y = int.Parse(txt2ndnum.Text);


                //Stage 2 process _ concatination of Full date
                z = x + y;


                //Stage 3 output
                lbloutput.Text = z.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers. Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt1stnum.Clear();
            txt2ndnum.Clear();
            lbloutput.Text = string.Empty;
           
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }
    }
    }
