using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRantalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                String name;
                int RentalDays, DrivingExperience, Age;

                name = txtCustomerName.Text;

                Age = int.Parse(txtAge.Text);
                RentalDays = int.Parse(txtRentalDays.Text);
                DrivingExperience = int.Parse(txtYearofExperience.Text);

                if (name == "")
                {
                    MessageBox.Show("Enter A Name:");
                    return;
                }

                if (Age <= 0 || RentalDays <= 0 || DrivingExperience < 0)
                {
                    MessageBox.Show("Plz Enter A Valid Numbers :");
                    return;
                }

                // Eligibility check: if not qualified, show the message and STOP
                if (Age < 18 || Age > 80 || DrivingExperience < 1)
                {
                    lstDetails.Items.Add("Rentail Details");
                    lstDetails.Items.Add("----------------------");
                    lstDetails.Items.Add("CustomerName Is:" + name);
                    lstDetails.Items.Add("CustomerAge Is:" + Age);
                    lstDetails.Items.Add("DrivingExperience Is:" + DrivingExperience);
                    lstDetails.Items.Add("RentalDays Are:" + RentalDays);
                    lstDetails.Items.Add("----------------------");

                    if (Age < 18 || Age > 80)
                    {
                        lstDetails.Items.Add("You Age is Not Illegiable:");
                    }
                    if (DrivingExperience < 1)
                    {
                        lstDetails.Items.Add("You Dont Have Experience For Driving:");
                    }

                    lstDetails.Items.Add("----------------------");

                    lstDetails.Items.Add("You Are Not Qualified:");
                    lstDetails.Items.Add("Rental Status: NOT ELIGIBLE.");
                    MessageBox.Show("We Can't Give This Costumer Acar ");
                    return;
                }

                //
                String VechicleType = "";
                double DailyRoute = 0;

                if (rdoeconomy.Checked)
                {
                    VechicleType = "Economy";
                    DailyRoute = 35;
                }
                else if (rdosuv.Checked)
                {
                    VechicleType = "SUV";
                    DailyRoute = 50;      // change to the SUV price from your assignment
                }
                else if (rdoluxury.Checked)
                {
                    VechicleType = "Luxury";
                    DailyRoute = 60;
                }
                else
                {
                    MessageBox.Show("Please Select A Car:");
                    return;
                }

                //
                double basicCost = DailyRoute * RentalDays;
                double discount = 0;

                // 14 days or more gets 10%, 7 days or more gets 5%
                if (RentalDays >= 14)
                {
                    discount = basicCost * 0.10;
                }
                else if (RentalDays >= 7)
                {
                    discount = basicCost * 0.05;
                }

                double insurance = 0;
                if (chkinsurance.Checked)
                {
                    insurance = 15 * RentalDays;
                }

                ///
                double youngshurge = 0;
                if (Age >= 18 && Age <= 24)   // change this range to match your assignment
                {
                    youngshurge = basicCost * 0.05;
                }

                ///FinalCost
                double finalcost = basicCost - discount + insurance + youngshurge;

                ///Final Result.
                lstDetails.Items.Add("Rentail Details");
                lstDetails.Items.Add("----------------------");
                lstDetails.Items.Add("CustomerName Is:" + name);
                lstDetails.Items.Add("CustomerAge Is:" + Age);
                lstDetails.Items.Add("DrivingExperience Is:" + DrivingExperience + " " + "Years.");
                lstDetails.Items.Add("RentalDays Are:" + RentalDays);
                lstDetails.Items.Add("VehicleType Is:" + VechicleType);
                lstDetails.Items.Add("DailyRate:$" + DailyRoute.ToString("F2"));
                lstDetails.Items.Add("Basic RentalCost:$" + basicCost.ToString("F2"));
                lstDetails.Items.Add("Discount:$" + discount.ToString("F2"));
                lstDetails.Items.Add("InsuranceCost:$" + insurance.ToString("F2"));
                lstDetails.Items.Add("YoungDriver SHourge:$" + youngshurge.ToString("F2"));
                lstDetails.Items.Add("Final RentalCost:$" + finalcost.ToString("F2"));
                lstDetails.Items.Add("----------------------");
                lstDetails.Items.Add("Rental Status: ELIGIBLE.");


            
                }
    catch (FormatException)
    {
        MessageBox.Show("There Is error On Your Code.");
    }
}







private void button2_Click(object sender, EventArgs e)
        {
            lis
        }
        private void btnEXit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


