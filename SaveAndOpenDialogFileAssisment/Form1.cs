using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SaveAndOpenDialogFileAssisment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter write;
                DialogResult result = Save.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Creating a new file and writing to it
                    write = File.CreateText(Save.FileName);
                    write.WriteLine("Apdulaahi");
                    write.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("You Have Canceled The File");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }


        private void btnSaveFileDialog_Click(object sender, EventArgs e)
        {
            StreamReader reads;

            DialogResult result;
            result = OpenFile.ShowDialog();


            if (result == DialogResult.OK)
            {

                reads = File.OpenText(OpenFile.FileName);

                string lines;
                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();
                    listBox1.Items.Add(lines);
                }

                reads.Close();

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("No file choosed");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter write;
                write = File.AppendText(Save.FileName);

                if (txtName.Text == "")
                {
                    MessageBox.Show("Write a name first.");
                    return;
                }
                if (Save.ShowDialog() == DialogResult.OK)
                {

                    write.WriteLine(txtName.Text);
                    write.Close();

                    MessageBox.Show("Saved");
                    txtName.Clear();   // empty the textbox so you can't save the same name twice by accident
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            }
        }
    }
