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
        }
        /// <summary>
        /// Method to invoke read from controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            controller.LoadAll(listView1);
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
    }
}
