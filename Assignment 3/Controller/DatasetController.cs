/*
 * Felipe Magnago - 040915490
 * Programming Language Research Project - Assignment 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3.Controller
{
    /// <summary>
    /// This class perform all the CRUD operations
    /// </summary>
    public class DatasetController
    {
        static readonly string file = "D:\\Projects\\Assignment 3\\13100262.csv";

        /// <summary>
        /// Method to read all data from the dataset
        /// </summary>
        /// <param name="datasetList"></param>
        public void LoadAll(ListView datasetList)
        {
            try
            {


                using (StreamReader stream = new StreamReader(file))
                {

                    List<Model.DatasetModel> list = new List<Model.DatasetModel>();


                    stream.ReadLine();

                    while (!stream.EndOfStream)
                    {
                        list.Add(Model.DatasetModel.getModel(stream.ReadLine()));
                    }


                    for (int i = 0; i < list.Count(); i++)
                    {
                        ListViewItem listViewItem = new ListViewItem(list[i].ID);
                        listViewItem.SubItems.Add(list[i].REF_DATE);
                        listViewItem.SubItems.Add(list[i].GEO);
                        listViewItem.SubItems.Add(list[i].DGUID);
                        listViewItem.SubItems.Add(list[i].Sex);
                        listViewItem.SubItems.Add(list[i].Age_group);
                        listViewItem.SubItems.Add(list[i].Student_response);
                        listViewItem.SubItems.Add(list[i].UOM);
                        listViewItem.SubItems.Add(list[i].UOM_ID);
                        listViewItem.SubItems.Add(list[i].SCALAR_FACTOR);
                        listViewItem.SubItems.Add(list[i].SCALAR_ID);
                        listViewItem.SubItems.Add(list[i].VECTOR);
                        listViewItem.SubItems.Add(list[i].COORDINATE);
                        listViewItem.SubItems.Add(list[i].VALUE);
                        listViewItem.SubItems.Add(list[i].STATUS);
                        listViewItem.SubItems.Add(list[i].SYMBOL);
                        listViewItem.SubItems.Add(list[i].TERMINATED);
                        listViewItem.SubItems.Add(list[i].DECIMALS);
                        datasetList.Items.Add(listViewItem);

                    }


                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Method to delete selected data
        /// </summary>
        /// <param name="id"></param>
        public void DeleteData(string id)
        {
            string tempFile = "D:\\Projects\\Assignment 3\\13100262 - copy.csv";
            StreamWriter writer = File.CreateText(tempFile);

            using (StreamReader stream = new StreamReader(file))
            {

                while (!stream.EndOfStream)
                {
                    string csvRow = stream.ReadLine();
                    string csvRowId = csvRow.Split(',')[0];

                    if (csvRowId.Equals(id))
                    {

                        Console.WriteLine(csvRowId);
                    }
                    else
                    {
                        writer.WriteLine(csvRow);
                        writer.Flush();
                    }
                }
          
                    
            }

            writer.Close();
            File.Delete(file);
            File.Move(tempFile, file);
            
        }
        /// <summary>
        /// Method to add data into dataset 
        /// </summary>
        /// <param name="datasetModel"></param>
        public void AddData(Model.DatasetModel datasetModel)
        {
            StreamWriter writer = new StreamWriter(file, true);
            writer.WriteLine(datasetModel.ToStringCSV());
            writer.Close();
        }

        /// <summary>
        /// Method to edit data from the dataset 
        /// </summary>
        /// <param name="datasetModel"></param>
        public void EditData(Model.DatasetModel datasetModel)
        {
            string tempFile = "D:\\Projects\\Assignment 3\\13100262 - copy.csv";
            StreamWriter writer = File.CreateText(tempFile);

            using (StreamReader stream = new StreamReader(file))
            {

                while (!stream.EndOfStream)
                {
                    string csvRow = stream.ReadLine();
                    string csvRowId = csvRow.Split(',')[0];

                    if (csvRowId.Equals(datasetModel.ID))
                    {

                        writer.WriteLine(datasetModel.ToStringCSV());
                        writer.Flush();
                    }
                    else
                    {
                        writer.WriteLine(csvRow);
                        writer.Flush();
                    }
                }


            }

            writer.Close();
            File.Delete(file);
            File.Move(tempFile, file);
        }
    }
}
