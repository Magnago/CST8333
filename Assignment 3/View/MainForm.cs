/*
 * Felipe Magnago - 040915490
 * Programming Language Research Project - Final Project
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3.View
{
    /// <summary>
    /// Method to invoke main form
    /// </summary>
    public partial class MainForm : Form
    {
        Controller.DatasetController controller;
        /// <summary>
        /// Method to initialize main form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller.DatasetController();
            controller.readAll(listView1);
            fillChart("Sex");
        }
        /// <summary>
        /// Method to invoke read from controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            controller.readAll(listView1);
        }
        /// <summary>
        /// Method to invoke add from controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();

            addForm.setListViewItem(listView1.Items[listView1.Items.Count - 1]);

            addForm.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Method to invoke edit from controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = listView1.SelectedItems[0];

                editForm.setListViewItem(listViewItem);

                Hide();
                editForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("You need to select an item from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Method to invoke delete from controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            for (var i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    controller.DeleteData(listView1.Items[i].SubItems[0].Text);
                    listView1.Items[i].Remove();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controller.insertDataFromCSV();
            MessageBox.Show("Records inserted to database from csv dataset");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controller.sortById(listView1);   
            MessageBox.Show("Listview ordered");
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void fillChart(string type)
        {
            if (type.Equals("Sex"))
            {
                chart1.Series["Chart"].Points.AddXY("Male", controller.sexGroupCount("Males"));
                chart1.Series["Chart"].Points.AddXY("Female", controller.sexGroupCount("Females"));
                chart1.Titles.Add("Sex Group");
            }
            else if (type.Equals("Student_response"))
            {
                chart1.Series["Chart"].Points.AddXY("Rarely or never", controller.studentResponseCount("Rarely or never"));
                chart1.Series["Chart"].Points.AddXY("Sometimes", controller.studentResponseCount("Sometimes"));
                chart1.Series["Chart"].Points.AddXY("Often", controller.studentResponseCount("Often"));
                chart1.Series["Chart"].Points.AddXY("Always", controller.studentResponseCount("Always"));
                chart1.Series["Chart"].Points.AddXY("Do not ride a bicycle", controller.studentResponseCount("Do not ride a bicycle"));
                chart1.Titles.Add("Student Response");
            }
            else if (type.Equals("SexStudentResponse"))
            {
                chart1.Series["Chart"].Points.AddXY("Male and Rarely or never", controller.sexAndstudentResponseCount("Rarely or never", "Males"));
                chart1.Series["Chart"].Points.AddXY("Male and Sometimes", controller.sexAndstudentResponseCount("Sometimes", "Males"));
                chart1.Series["Chart"].Points.AddXY("Male and Often", controller.sexAndstudentResponseCount("Often", "Males"));
                chart1.Series["Chart"].Points.AddXY("Male and Always", controller.sexAndstudentResponseCount("Always", "Males"));
                chart1.Series["Chart"].Points.AddXY("Male and Do not ride a bicycle", controller.sexAndstudentResponseCount("Do not ride a bicycle", "Males"));
                chart1.Series["Chart"].Points.AddXY("Female and Rarely or never", controller.sexAndstudentResponseCount("Rarely or never", "Females"));
                chart1.Series["Chart"].Points.AddXY("Female and Sometimes", controller.sexAndstudentResponseCount("Sometimes", "Females"));
                chart1.Series["Chart"].Points.AddXY("Female and Often", controller.sexAndstudentResponseCount("Often", "Females"));
                chart1.Series["Chart"].Points.AddXY("Female and Always", controller.sexAndstudentResponseCount("Always", "Females"));
                chart1.Series["Chart"].Points.AddXY("Female and Do not ride a bicycle", controller.sexAndstudentResponseCount("Do not ride a bicycle", "Females"));
                chart1.Titles.Add("Sex and Student Response");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Chart"].Points.Clear();
            chart1.Titles.Clear();
            fillChart("Sex");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Chart"].Points.Clear();
            chart1.Titles.Clear();
            fillChart("Student_response");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series["Chart"].Points.Clear();
            chart1.Titles.Clear();
            fillChart("SexStudentResponse");
        }
    }
}
