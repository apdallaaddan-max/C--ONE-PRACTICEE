using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelBookingSytem
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

                

                string Name;
                int Age, night;
                double NumberOfguest;
                ///

                Name = txtName.Text;
                Age = int.Parse(txtAge.Text);
                night = int.Parse(txtNights.Text);
                NumberOfguest = double.Parse(txtNumofGuest.Text);

                ///
                if (Name == "")
                {
                    MessageBox.Show("Enter Your Name");
                    return;
                }
                if (Age < 18 || Age > 100)
                {
                    lstBooking.Items.Add("Booking Status: Rejected. Age must be between 18 and 100.");
                    return;
                }

                if (night < 1 || night > 30)
                {
                    lstBooking.Items.Add("Booking Status: Rejected. Nights must be between 1 and 30.");
                    
                }

                if (NumberOfguest < 1 || NumberOfguest > 6)
                {
                    lstBooking.Items.Add("Booking Status: Rejected. Guests must be between 1 and 6.");
                    
                }

                ///
                string Roomtype = "";
                int RoomRAte = 0;
                int MaxGuest = 0;

                if (rdoStandard.Checked)
                {
                    Roomtype = "Standard";
                    RoomRAte = 30;
                    MaxGuest = 6;
                }
                else if (rdoNormal.Checked)
                {
                    Roomtype = "Normal";
                    RoomRAte = 50;
                    MaxGuest = 6;
                }
                else if (rdohigh.Checked)
                {
                    Roomtype = "Hight";
                    RoomRAte = 100;
                    MaxGuest = 6;
                }
                else
                {
                    MessageBox.Show("Please Select RoomType");
                   
                }

                ///
                String RejectionReason = "";
                bool booking = true;
                if (NumberOfguest > MaxGuest)
                {
                    booking = false;
                    RejectionReason = "This Room Can't Accommodate More Than " + MaxGuest + " Guests.";
                }
                if (booking == false)
                {
                    lstBooking.Items.Add("Booking Status: Rejected");
                    lstBooking.Items.Add("----------------------");
                    lstBooking.Items.Add("Reason: " + RejectionReason);
                    return;
                }

                double RoomTotal;
                RoomTotal = RoomRAte * night;
                double nightDiscount = 0;
                double seniordiscount = 0;
                double BreakFastcost = 0;
                double ServiceCharge = 0;

                if (night >= 5 && night <= 9)
                {
                    nightDiscount = RoomTotal * 0.05;
                }
                else if (night >= 10)
                {
                    nightDiscount = RoomTotal * 0.12;
                }
                double discountRoomTotal = 0;
                discountRoomTotal = RoomTotal - nightDiscount;
                //
                if (Age >= 60)
                {
                    seniordiscount = discountRoomTotal * 0.05;
                }
                double afterdiscount = 0;
                afterdiscount = discountRoomTotal - seniordiscount;

                ///

                if (chkAdditional.Checked)
                {
                    BreakFastcost = 10 * NumberOfguest * night;
                }
                double subtotal;
                subtotal = afterdiscount + BreakFastcost;

                ServiceCharge = subtotal * 0.10;   // ASSUMED 10%, use your brief's rate

                // 11. Calculate final bill
                double finalTotal = subtotal + ServiceCharge;

                // 12. Display booking details
                lstBooking.Items.Add("HOTEL ROOM BOOKING DETAILS");
                lstBooking.Items.Add("==============================");
                lstBooking.Items.Add("Booking Status: APPROVED");
                lstBooking.Items.Add("Guest Name: " + Name);
                lstBooking.Items.Add("Guest Age: " + Age);
                lstBooking.Items.Add("Room Type: " + Roomtype);
                lstBooking.Items.Add("Room Rate per Night: $" + RoomRAte.ToString("F2"));
                lstBooking.Items.Add("Number of Nights: " + night);
                lstBooking.Items.Add("Number of Guests: " + NumberOfguest);
                lstBooking.Items.Add("");
                lstBooking.Items.Add("Room Cost: $" + RoomTotal.ToString("F2"));
                lstBooking.Items.Add("Night Discount: -$" + nightDiscount.ToString("F2"));
                lstBooking.Items.Add("Senior Discount: -$" + seniordiscount.ToString("F2"));
                lstBooking.Items.Add("Breakfast Cost: $" + BreakFastcost.ToString("F2"));
                lstBooking.Items.Add("Service Charge: $" + ServiceCharge.ToString("F2"));
                lstBooking.Items.Add("==============================");
                lstBooking.Items.Add("FINAL TOTAL: $" + finalTotal.ToString("F2"));

            }
            catch (Exception Ex)
            {
                MessageBox.Show("There is Error on Your Code: " + Ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBooking.Items.Clear(); 
            txtName.Text = string.Empty;
            txtNights.Text = string.Empty;
            txtNumofGuest.Text = string.Empty;
            txtAge.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
   