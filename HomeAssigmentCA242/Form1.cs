using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssigmentCA242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            // Stage 1 creating variables
            string dayOf_the_Weeuk, NameOfTheDay, NumericOfMonth, Year, Full_Date;

            //initial Values To variables
            dayOf_the_Weeuk = txtdayoftheweek.Text;
            NameOfTheDay = txtdayofthemonth.Text;
            NumericOfMonth=txtmonth.Text;
            Year=txtyear.Text;

            //Stage 2 process _ concatination of Full date
            Full_Date= dayOf_the_Weeuk+ ","+ NameOfTheDay+ ","+ NumericOfMonth+
                ","+ Year;


            //Stage 3 output usinf label
            lbloutput.Text = Full_Date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clearing Text box 
            txtdayoftheweek.Clear();
            txtmonth.Text = "";
            txtyear.Clear();
            txtdayofthemonth.Text= string.Empty;
            txtmonth.Text= string.Empty;


            //clearing label
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form close _ using this keywoard and close fuction
            this.Close();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {
            lbloutput.Text= string.Empty;   

        }
    }
}
