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

namespace Airline_TicketBookingSystem
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
                {
                    

                    string name, validation = "";
                    int Personage, ticket;
                    double weight;
                    bool bookingApproved = true;

                    ///

                    name = txtname.Text;

                    Personage=int.Parse(txtAge.Text);
                    ticket = int.Parse(txtTicket.Text);
                    weight = double.Parse(txtWeight.Text);
                    ///

                    if (txtname.Text == "")
                    {
                        MessageBox.Show("Enter Aname.");
                        return;
                    }
                    name = txtname.Text;

                    if (!int.TryParse(txtAge.Text, out Personage))
                    {
                        MessageBox.Show("Enret avalid age.");
                        return;
                    }
                    if (!int.TryParse(txtTicket.Text, out ticket))
                    {
                        MessageBox.Show("Enret avalid Ticket.");
                        return;
                    }
                    if (!double.TryParse(txtWeight.Text, out weight))
                    {
                        MessageBox.Show("Enret avalid Weight.");
                        return;
                    }

                    if (name == "")
                    {
                        MessageBox.Show("Enter Aname.");
                        return;
                    }

                    if (Personage < 1 || Personage > 100)
                    {
                        MessageBox.Show("Age must be between 1 and 100.");
                        return;
                    }

                    if (ticket < 1 || ticket > 5)
                    {
                        MessageBox.Show("Tickets must be between 1 and 5.");
                        return;
                    }

                    if (weight < 0 || weight > 50)
                    {
                        MessageBox.Show("Baggage weight must be between 0 and 50 kg.");
                        return;
                    }


                    if (rdo1stClass.Checked && rdoNormalClass.Checked && rdoBusinessClass.Checked)
                        {
                            MessageBox.Show("Please select a travel class.");
                            return;
                        }

                        if (Personage < 12 && rdo1stClass.Checked)
                        {
                            MessageBox.Show("Passengers below 12 cannot book First Class." + " ");
                            return;
                        }

                        ///Ticket Price (ASSUMED prices, change them to your assignment's)
                        string travelClass = "";
                        double ticketPrice = 0;
                        // ... the rest of your code stays the same

                        ///

                        if (bookingApproved == false)
                    {
                        listBox1.Items.Add("Passenger Name:" + " " + name);
                        listBox1.Items.Add("Booking Status: REJECTED");
                        listBox1.Items.Add("Reason: " + " " + validation);
                        MessageBox.Show("Booking Rejected: " + " " + validation);
                        return;
                    
                    }

                    ///Ticket Price (ASSUMED prices, change them to your assignment's)
                    

                    if (rdo1stClass.Checked)
                    {
                        travelClass = "First Class";
                        ticketPrice = 300;
                    }
                    else if (rdoBusinessClass.Checked)
                    {
                        travelClass = "Business Class";
                        ticketPrice = 200;
                    }
                    else if (rdoNormalClass.Checked)
                    {
                        travelClass = "Normal Class";
                        ticketPrice = 100;
                    }

                    ///Basic Ticket Cost = Ticket Price x Number of Tickets
                    double basicCost = ticketPrice * ticket;

                    ///Discounts
                    double discountPercent = 0;

                    if (ticket == 5)
                    {
                        discountPercent += 0.10;
                    }
                    else if (ticket >= 3)
                    {
                        discountPercent += 0.05;
                    }

                    if (Personage <= 12)
                    {
                        discountPercent += 0.20;
                    }
                    else if (Personage >= 60)
                    {
                        discountPercent += 0.10;
                    }

                    double discount = basicCost * discountPercent;

                    ///Insurance
                    double insurance = 0;
                    if (chkInsurance.Checked)
                    {
                        insurance = 25 * ticket;
                    }

                    ///Baggage (free up to 20kg, ASSUMED $5 per extra kg)
                    double baggageFee = 0;
                    if (weight > 20)
                    {
                        baggageFee = (weight - 20) * 5;
                    }

                    ///FinalCost
                    double finalcost = basicCost - discount + insurance + baggageFee;

                    ///Final Result.
                    listBox1.Items.Add("Airline Booking Details");
                    listBox1.Items.Add("----------------------");
                    listBox1.Items.Add("Your name is:" +""+ name);
                    listBox1.Items.Add("Your age is:" +"" +Personage);
                    listBox1.Items.Add("The Amount of Ticket You Have is:" + " " + ticket);
                    listBox1.Items.Add("The weight of your baggage are: " + weight + " kg" + " ");
                    listBox1.Items.Add("Travel Class:" + " " + travelClass);
                    listBox1.Items.Add("Ticket Price:$" + " " + ticketPrice.ToString("F2"));
                    listBox1.Items.Add("Basic Ticket Cost:$" + " " + basicCost.ToString("F2"));
                    listBox1.Items.Add("Discount:$" + " "  + discount.ToString("F2"));
                    listBox1.Items.Add("Insurance Cost:$" + " " + insurance.ToString("F2"));
                    listBox1.Items.Add("Baggage Fee:$" + " " + baggageFee.ToString("F2"));
                    listBox1.Items.Add("Final Cost:$" + " " + finalcost.ToString("F2"));
                    listBox1.Items.Add("----------------------");
                    listBox1.Items.Add("Booking Status: APPROVED");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("There is Error on Your Code: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtAge.Text = string.Empty;
            txtname.Text= string.Empty;
            txtTicket.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
