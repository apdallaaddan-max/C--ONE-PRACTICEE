using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string GuestName, RoomType;
                int NumberOfNights, PriceNight;

                //
                GuestName = lblGuestName.Text;
                RoomType = lblRoomType.Text;

                //
                NumberOfNights = int.Parse(txtNights.Text);
                PriceNight = int.Parse(txtPriceNight.Text);


                Double ServiceTax, Total, Discount;

                ServiceTax = (NumberOfNights * PriceNight) * 0.10;
                Discount= (NumberOfNights * PriceNight) * 0.05;
                Total = (NumberOfNights * PriceNight) + ServiceTax-Discount;



                //output
                txtTax.Text = "$" + ServiceTax.ToString("");
                txtdiscount.Text = "$" + Discount.ToString("");
                txtamount.Text = "$" + Total.ToString("");
               




            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers. Error: " + ex.Message);



            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtamount.Clear();
            txtdiscount.Clear();
            txtTax.Clear();
            txtNights.Clear();
            txtPriceNight.Clear();
            txtGuestName.Clear();
            txtRoomType.SelectedIndex = -1;
           
        }
    }
}