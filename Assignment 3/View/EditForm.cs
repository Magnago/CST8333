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
    /// Class to show the edit form
    /// </summary>
    public partial class EditForm : Form
    {
        ListViewItem listViewItem;
        Controller.DatasetController controller;
        /// <summary>
        /// Initiate the edit form
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            controller = new Controller.DatasetController();
        }
        /// <summary>
        /// Set ListViewItem
        /// </summary>
        /// <param name="listViewItem"></param>
        public void setListViewItem(ListViewItem listViewItem)
        {
            this.listViewItem = listViewItem;
        }

        /// <summary>
        /// Get ListViewItem
        /// </summary>
        /// <returns></returns>
        public ListViewItem getListViewItem()
        {
            return listViewItem;
        }

        /// <summary>
        /// Method to Load the values in the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadEditForm(object sender, EventArgs e)
        {
            textBox1.Text = getListViewItem().SubItems[1].Text;
            textBox2.Text = getListViewItem().SubItems[2].Text;
            textBox3.Text = getListViewItem().SubItems[3].Text;
            textBox4.Text = getListViewItem().SubItems[4].Text;
            textBox5.Text = getListViewItem().SubItems[5].Text;
            textBox6.Text = getListViewItem().SubItems[6].Text;
            textBox7.Text = getListViewItem().SubItems[7].Text;
            textBox8.Text = getListViewItem().SubItems[8].Text;
            textBox9.Text = getListViewItem().SubItems[9].Text;
            textBox10.Text = getListViewItem().SubItems[10].Text;
            textBox11.Text = getListViewItem().SubItems[11].Text;
            textBox12.Text = getListViewItem().SubItems[12].Text;
            textBox13.Text = getListViewItem().SubItems[13].Text;
            textBox14.Text = getListViewItem().SubItems[14].Text;
            textBox15.Text = getListViewItem().SubItems[15].Text;
            textBox16.Text = getListViewItem().SubItems[16].Text;
            textBox17.Text = getListViewItem().SubItems[17].Text;
        }

        /// <summary>
        /// Method to save the changes made on the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            controller.EditData(new Model.DatasetModel(getListViewItem().SubItems[0].Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text,
                textBox15.Text, textBox16.Text, textBox17.Text));

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Method to cancel and go back to main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
