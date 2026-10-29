using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace AssigmentFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ceating File
                StreamWriter Files;

                // Process the file..
                //Open The file - Creating new file..

                Files = File.CreateText("Index.txt");

                //Process The File- Writting File..
                Files.WriteLine("Welcome To My Github");
                Files.WriteLine("My Name: Apdulaahi Aadam Hassan.");

                // Close The File..
                MessageBox.Show("File Created Successfully.");

                Files.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lstResult.Items.Clear();

                string[] Read = File.ReadAllLines("Index.txt");

                foreach (string Line in Read)
                {
                    lstResult.Items.Add(Line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You Have to Read The file" + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstResult.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item first.");
                    return;
                }
                string selectedItem = lstResult.SelectedItem.ToString();
                lstResult.Items.Remove(selectedItem);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("You Have To Select An Item" + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("Index.txt"))
                {
                    File.Delete("Index.txt");
                    lstResult.Items.Clear();
                    MessageBox.Show("File Deleted Successfully.");
                    return;
                }
                else
                {
                    MessageBox.Show("File Not Found.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    }


