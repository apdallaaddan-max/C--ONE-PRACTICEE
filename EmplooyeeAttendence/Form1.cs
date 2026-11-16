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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmplooyeeAttendence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string Name, Dep;
                //
                Name = txtName.Text;
                Dep = txtDep.Text;
                id = int.Parse(txtId.Text);

                //
                if (id < 0)
                {
                    MessageBox.Show("You id Can't Be Zero");
                    return;
                }
                if (txtName.Text == "")
                {
                    MessageBox.Show("Write a name first.");
                    return;
                }

                if (SaveAs.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter write;
                    write = File.AppendText(SaveAs.FileName);

                    write.WriteLine(txtName.Text);
                    write.WriteLine(txtId.Text);
                    write.WriteLine(txtDep.Text);

                    string status = "";
                    if (rdoPresent.Checked)
                    {
                        status = "Present";
                    }
                    else if (rdoAbsent.Checked)
                    {
                        status = "Absent";
                    }

                    //write.WriteLine(txtId.Text + "," + txtName.Text + "," + txtDep.Text + "," + status);
                    

                    write.Close();
                    MessageBox.Show("File Appended");
                }
                else
                {
                    MessageBox.Show("FIle Is not Appended");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenAs.ShowDialog() == DialogResult.OK)
                {
                    lst1.Items.Clear();

                    StreamReader read;
                    read = File.OpenText(OpenAs.FileName);

                    while (!read.EndOfStream)
                    {
                        lst1.Items.Add(read.ReadLine());
                    }

                    read.Close();
                }
                string status = "";
                if (rdoPresent.Checked)
                {
                    status = "Present";
                }
                else if (rdoAbsent.Checked)
                {
                    status = "Absent";
                }
           
                lst1.Items.Add(txtId.Text + "," + txtName.Text + "," + txtDep.Text + "," + status);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst1.SelectedIndex == -1)
                {
                    MessageBox.Show("Select an item first.");
                    return;
                }
                else { lst1.Items.RemoveAt(lst1.SelectedIndex);}
                lst1.Items.Remove(lst1.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter write;
                write = File.AppendText(SaveAs.FileName);

                for (int i = 0; i < lst1.Items.Count; i++)
                {
                    write.WriteLine(lst1.Items.ToString());
                }

                write.Close();
                MessageBox.Show("Records Saved");
            
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }
    }
    }

