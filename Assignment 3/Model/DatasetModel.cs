/*
 * Felipe Magnago - 040915490
 * Programming Language Research Project - Assignment 3
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment_3.Model
{
    /// <summary>
    /// Class to hold the object and convert to csv format 
    /// </summary>
    public class DatasetModel
    {
        public string ID { set; get; }
        public string REF_DATE { set; get; }
        public string GEO { set; get; }
        public string DGUID { set; get; }
        public string Sex { set; get; }
        public string Age_group { set; get; }
        public string Student_response { set; get; }
        public string UOM { set; get; }
        public string UOM_ID { set; get; }
        public string SCALAR_FACTOR { set; get; }
        public string SCALAR_ID { set; get; }
        public string VECTOR { set; get; }
        public string COORDINATE { set; get; }
        public string VALUE { set; get; }
        public string STATUS { set; get; }
        public string SYMBOL { set; get; }
        public string TERMINATED { set; get; }
        public string DECIMALS { set; get; }

        /// <summary>
        /// Constructor that receives the information
        /// </summary>
        /// <param name="REF_DATE"></param>
        /// <param name="GEO"></param>
        /// <param name="DGUID"></param>
        /// <param name="Sex"></param>
        /// <param name="Age_group"></param>
        /// <param name="Student_response"></param>
        /// <param name="UOM"></param>
        /// <param name="UOM_ID"></param>
        /// <param name="SCALAR_FACTOR"></param>
        /// <param name="SCALAR_ID"></param>
        /// <param name="VECTOR"></param>
        /// <param name="COORDINATE"></param>
        /// <param name="VALUE"></param>
        /// <param name="STATUS"></param>
        /// <param name="SYMBOL"></param>
        /// <param name="TERMINATED"></param>
        /// <param name="DECIMALS"></param>
        public DatasetModel(string ID, string REF_DATE, string GEO, string DGUID, string Sex,
            string Age_group, string Student_response, string UOM,
            string UOM_ID, string SCALAR_FACTOR, string SCALAR_ID, string VECTOR,
            string COORDINATE, string VALUE, string STATUS, string SYMBOL, string TERMINATED, string DECIMALS)
        {
            this.ID = ID;
            this.REF_DATE = REF_DATE;
            this.GEO = GEO;
            this.DGUID = DGUID;
            this.Sex = Sex;
            this.Age_group = Age_group;
            this.Student_response = Student_response;
            this.UOM = UOM;
            this.UOM_ID = UOM_ID;
            this.SCALAR_FACTOR = SCALAR_FACTOR;
            this.SCALAR_ID = SCALAR_ID;
            this.VECTOR = VECTOR;
            this.COORDINATE = COORDINATE;
            this.VALUE = VALUE;
            this.STATUS = STATUS;
            this.SYMBOL = SYMBOL;
            this.TERMINATED = TERMINATED;
            this.DECIMALS = DECIMALS;
        }

        /// <summary>
        /// Method to split the csv line and return the model
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public static DatasetModel getModel(string line)
        {
            Regex CSVParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

            string[] values = CSVParser.Split(line);

            //For using in the complete csv file
            DatasetModel model = new DatasetModel(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8],
                values[9], values[10], values[11], values[12], values[13], values[14], values[15], values[16], values[17]);

            return model;
        }

        /// <summary>
        /// ToString method to show the columns and format the result
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID" + ID + "REF_DATE: " + REF_DATE + " GEO: " + GEO + " DGUID: " + DGUID + " Sex: " + Sex + " Age_group: " + Age_group
                    + " Student_response: " + Student_response + " UOM: " + UOM + " UOM_ID: " + UOM_ID + " SCALAR_FACTOR: " + SCALAR_FACTOR
                    + " SCALAR_ID: " + SCALAR_ID + " VECTOR: " + VECTOR + " COORDINATE: " + COORDINATE + " VALUE: " + VALUE
                    + " STATUS: " + STATUS + " SYMBOL: " + SYMBOL + " TERMINATED: " + TERMINATED + " DECIMALS: " + DECIMALS;
        }

        /// <summary>
        /// ToString method to split the csv data using , and show the result
        /// </summary>
        /// <returns></returns>
        public string ToStringCSV()
        {
            return ID + "," + REF_DATE + "," + GEO + "," + DGUID + "," + Sex + "," + Age_group + "," + Student_response + "," + UOM + "," +
                 UOM_ID + "," + SCALAR_FACTOR + "," + SCALAR_ID + "," +
                 VECTOR + "," + COORDINATE + "," + VALUE + "," + STATUS +
                 "," + SYMBOL + "," + TERMINATED + "," + DECIMALS;
        }
    }
}
