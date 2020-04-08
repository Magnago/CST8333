/*
 * Felipe Magnago - 040915490
 * Programming Language Research Project - Assignment 3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3.View
{
    /// <summary>
    /// Class to show the AddForm and add new records
    /// </summary>
    public partial class AddForm : Form
    {
        ListViewItem listViewItem;
        Controller.DatasetController controller;
        /// <summary>
        /// Initialize AddForm
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            controller = new Controller.DatasetController();
        }
        /// <summary>
        /// Set lisViewItem method
        /// </summary>
        /// <param name="listViewItem"></param>
        public void setListViewItem(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
        }

        /// <summary>
        /// Get ListViewItem Method
        /// </summary>
        /// <returns></returns>
        public ListViewItem getListViewItem()
        {
            return listViewItem;
        }

        /// <summary>
        /// Method to add record it sends the information to the controller to write on file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button1_Click(object sender, EventArgs e)
        {
            //int ID = Int32.Parse(getListViewItem().SubItems[0].Text) + 1;
            controller.AddData(new Model.DatasetModel("", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
            textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text,
            textBox15.Text, textBox16.Text, textBox17.Text));

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Method to cancel and hide the add form and show the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();

        }
    }
}
