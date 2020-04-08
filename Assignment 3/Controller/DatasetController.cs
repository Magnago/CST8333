/*
 * Felipe Magnago - 040915490
 * Programming Language Research Project - Final Project
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment_3.Controller
{
    /// <summary>
    /// This class perform all the CRUD operations
    /// </summary>
    public class DatasetController
    {
        static readonly string file = "D:\\Projects\\Assignment 3\\13100262.csv";
        Model.DBAccess dbAccess;

        /// <summary>
        /// Constructor
        /// </summary>
        public DatasetController()
        {
            dbAccess = new Model.DBAccess();
        }

        /// <summary>
        /// Method to insert data from CSV into database
        /// </summary>
        public void insertDataFromCSV()
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
                        String ID = list[i].ID;
                        String REF_DATE = list[i].REF_DATE;
                        String GEO = list[i].GEO;
                        String DGUID = list[i].DGUID;
                        String SEX = list[i].Sex;
                        String Age_group = list[i].Age_group;
                        String Student_response = list[i].Student_response;
                        String UOM = list[i].UOM;
                        String UOM_ID = list[i].UOM_ID;
                        String SCALAR_FACTOR = list[i].SCALAR_FACTOR;
                        String SCALAR_ID = list[i].SCALAR_ID;
                        String VECTOR = list[i].VECTOR;
                        String COORDINATE = list[i].COORDINATE;
                        String db_VALUE = list[i].VALUE;
                        String db_STATUS = list[i].STATUS;
                        String SYMBOL = list[i].SYMBOL;
                        String TERMINATED = list[i].TERMINATED;
                        String DECIMALS = list[i].DECIMALS;
                        //Query to insert data to database
                        SqlCommand insertCommand = new SqlCommand("insert into Exercise4(ID,REF_DATE,GEO,DGUID,SEX" +
                            ",Age_group,Student_response,UOM,UOM_ID,SCALAR_FACTOR,SCALAR_ID,VECTOR,COORDINATE,db_VALUE,db_STATUS" +
                            ",SYMBOL,TERMINATED,DECIMALS) values(@ID, @REF_DATE, @GEO, @DGUID, @SEX, @Age_group, @Student_response" +
                            ", @UOM, @UOM_ID, @SCALAR_FACTOR, @SCALAR_ID, @VECTOR, @COORDINATE, @db_VALUE, @db_STATUS, @SYMBOL, @TERMINATED, @DECIMALS)");

                        //Securing 
                        insertCommand.Parameters.AddWithValue("@ID", ID);
                        insertCommand.Parameters.AddWithValue("@REF_DATE", REF_DATE);
                        insertCommand.Parameters.AddWithValue("@GEO", GEO);
                        insertCommand.Parameters.AddWithValue("@DGUID", DGUID);
                        insertCommand.Parameters.AddWithValue("@SEX", SEX);
                        insertCommand.Parameters.AddWithValue("@Age_group", Age_group);
                        insertCommand.Parameters.AddWithValue("@Student_response", Student_response);
                        insertCommand.Parameters.AddWithValue("@UOM", UOM);
                        insertCommand.Parameters.AddWithValue("@UOM_ID", UOM_ID);
                        insertCommand.Parameters.AddWithValue("@SCALAR_FACTOR", SCALAR_FACTOR);
                        insertCommand.Parameters.AddWithValue("@SCALAR_ID", SCALAR_ID);
                        insertCommand.Parameters.AddWithValue("@VECTOR", VECTOR);
                        insertCommand.Parameters.AddWithValue("@COORDINATE", COORDINATE);
                        insertCommand.Parameters.AddWithValue("@db_VALUE", db_VALUE);
                        insertCommand.Parameters.AddWithValue("@db_STATUS", db_STATUS);
                        insertCommand.Parameters.AddWithValue("@SYMBOL", SYMBOL);
                        insertCommand.Parameters.AddWithValue("@TERMINATED", TERMINATED);
                        insertCommand.Parameters.AddWithValue("@DECIMALS", DECIMALS);

                        dbAccess.executeQuery(insertCommand);
                        dbAccess.closeConn();
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Method to read all data from the dataset
        /// </summary>
        /// <param name="datasetList"></param>
        public void readAll(ListView datasetList)
        {
            try
            {
                String selectQuery = "select * from dbo.Exercise4";

                SqlDataReader sqlReader = dbAccess.readDatathroughReader(selectQuery);
                List<Model.DatasetModel> list = new List<Model.DatasetModel>();

                while (sqlReader.Read())
                {
                    Model.DatasetModel readModel = new Model.DatasetModel(sqlReader.GetValue(0).ToString(), sqlReader.GetValue(1).ToString(), sqlReader.GetValue(2).ToString(), sqlReader.GetValue(3).ToString(),
                            sqlReader.GetValue(4).ToString(), sqlReader.GetValue(5).ToString(), sqlReader.GetValue(6).ToString(), sqlReader.GetValue(7).ToString(), sqlReader.GetValue(8).ToString(),
                            sqlReader.GetValue(9).ToString(), sqlReader.GetValue(10).ToString(), sqlReader.GetValue(11).ToString(), sqlReader.GetValue(12).ToString(), sqlReader.GetValue(13).ToString(),
                            sqlReader.GetValue(14).ToString(), sqlReader.GetValue(15).ToString(), sqlReader.GetValue(16).ToString(), sqlReader.GetValue(17).ToString());
                    list.Add(readModel);
                }
                datasetList.Items.Clear();

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
                dbAccess.closeConn();
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
            SqlCommand deleteCommand = new SqlCommand("delete from dbo.Exercise4 where ID = @ID");
            deleteCommand.Parameters.AddWithValue("@ID",id);
            dbAccess.executeQuery(deleteCommand);
            dbAccess.closeConn();

        }
        /// <summary>
        /// Method to add data into dataset 
        /// </summary>
        /// <param name="datasetModel"></param>
        public void AddData(Model.DatasetModel datasetModel)
        {
            String selectQuery = "select * from dbo.Exercise4";

            SqlDataReader sqlReader = dbAccess.readDatathroughReader(selectQuery);
            List<int> list = new List<int>();

            while (sqlReader.Read())
            {
                list.Add(Convert.ToInt32(sqlReader.GetValue(0)));
            }

            int max = list[0];
            for (int i = 1; i < list.Count(); i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            max += 1;
            dbAccess.closeConn();

            Model.DBAccess dBAccess = new Model.DBAccess();

            SqlCommand insertCommand = new SqlCommand("insert into Exercise4(ID,REF_DATE,GEO,DGUID,SEX" +
                ",Age_group,Student_response,UOM,UOM_ID,SCALAR_FACTOR,SCALAR_ID,VECTOR,COORDINATE,db_VALUE,db_STATUS" +
                ",SYMBOL,TERMINATED,DECIMALS) values(@ID, @REF_DATE, @GEO, @DGUID, @SEX, @Age_group, @Student_response" +
                ", @UOM, @UOM_ID, @SCALAR_FACTOR, @SCALAR_ID, @VECTOR, @COORDINATE, @db_VALUE, @db_STATUS, @SYMBOL, @TERMINATED, @DECIMALS)");

            //Securing 
            insertCommand.Parameters.AddWithValue("@ID", max.ToString());
            insertCommand.Parameters.AddWithValue("@REF_DATE", datasetModel.REF_DATE);
            insertCommand.Parameters.AddWithValue("@GEO", datasetModel.GEO);
            insertCommand.Parameters.AddWithValue("@DGUID", datasetModel.DGUID);
            insertCommand.Parameters.AddWithValue("@SEX", datasetModel.Sex);
            insertCommand.Parameters.AddWithValue("@Age_group", datasetModel.Age_group);
            insertCommand.Parameters.AddWithValue("@Student_response", datasetModel.Student_response);
            insertCommand.Parameters.AddWithValue("@UOM", datasetModel.UOM);
            insertCommand.Parameters.AddWithValue("@UOM_ID", datasetModel.UOM_ID);
            insertCommand.Parameters.AddWithValue("@SCALAR_FACTOR", datasetModel.SCALAR_FACTOR);
            insertCommand.Parameters.AddWithValue("@SCALAR_ID", datasetModel.SCALAR_ID);
            insertCommand.Parameters.AddWithValue("@VECTOR", datasetModel.VECTOR);
            insertCommand.Parameters.AddWithValue("@COORDINATE", datasetModel.COORDINATE);
            insertCommand.Parameters.AddWithValue("@db_VALUE", datasetModel.VALUE);
            insertCommand.Parameters.AddWithValue("@db_STATUS", datasetModel.STATUS);
            insertCommand.Parameters.AddWithValue("@SYMBOL", datasetModel.SYMBOL);
            insertCommand.Parameters.AddWithValue("@TERMINATED", datasetModel.TERMINATED);
            insertCommand.Parameters.AddWithValue("@DECIMALS", datasetModel.DECIMALS);

            dbAccess.executeQuery(insertCommand);
            dbAccess.closeConn();
        }

        /// <summary>
        /// Method to edit data from the dataset 
        /// </summary>
        /// <param name="datasetModel"></param>
        public void EditData(Model.DatasetModel datasetModel)
        {
            SqlCommand updateCommand = new SqlCommand("update Exercise4 set REF_DATE = @REF_DATE, GEO = @GEO, DGUID = @DGUID, SEX = @SEX, Age_group = @Age_group, " +
                "Student_response = @Student_response, UOM = @UOM, UOM_ID = @UOM_ID, SCALAR_FACTOR = @SCALAR_FACTOR, SCALAR_ID = @SCALAR_ID, VECTOR = @VECTOR," +
                "COORDINATE = @COORDINATE, db_VALUE = @db_VALUE, db_STATUS = @db_STATUS, SYMBOL = @SYMBOL, TERMINATED = @TERMINATED, DECIMALS = @DECIMALS where ID = @ID");

            updateCommand.Parameters.AddWithValue("@REF_DATE", datasetModel.REF_DATE);
            updateCommand.Parameters.AddWithValue("@GEO", datasetModel.GEO);
            updateCommand.Parameters.AddWithValue("@DGUID", datasetModel.DGUID);
            updateCommand.Parameters.AddWithValue("@SEX", datasetModel.Sex);
            updateCommand.Parameters.AddWithValue("@Age_group", datasetModel.Age_group);
            updateCommand.Parameters.AddWithValue("@Student_response", datasetModel.Student_response);
            updateCommand.Parameters.AddWithValue("@UOM", datasetModel.UOM);
            updateCommand.Parameters.AddWithValue("@UOM_ID", datasetModel.UOM_ID);
            updateCommand.Parameters.AddWithValue("@SCALAR_FACTOR", datasetModel.SCALAR_FACTOR);
            updateCommand.Parameters.AddWithValue("@SCALAR_ID", datasetModel.SCALAR_ID);
            updateCommand.Parameters.AddWithValue("@VECTOR", datasetModel.VECTOR);
            updateCommand.Parameters.AddWithValue("@COORDINATE", datasetModel.COORDINATE);
            updateCommand.Parameters.AddWithValue("@db_VALUE", datasetModel.VALUE);
            updateCommand.Parameters.AddWithValue("@db_STATUS", datasetModel.STATUS);
            updateCommand.Parameters.AddWithValue("@SYMBOL", datasetModel.SYMBOL);
            updateCommand.Parameters.AddWithValue("@TERMINATED", datasetModel.TERMINATED);
            updateCommand.Parameters.AddWithValue("@DECIMALS", datasetModel.DECIMALS);
            updateCommand.Parameters.AddWithValue("@ID", datasetModel.ID);

            dbAccess.executeQuery(updateCommand);
            dbAccess.closeConn();

        }
        /// <summary>
        /// Method to sort items by Id
        /// </summary>
        /// <param name="listView"></param>
        public void sortById(ListView listView)
        {
            String selectQuery = "select * from dbo.Exercise4";

            SqlDataReader sqlReader = dbAccess.readDatathroughReader(selectQuery);
            List<Model.DatasetModel> list = new List<Model.DatasetModel>();

            while (sqlReader.Read())
            {
                Model.DatasetModel readModel = new Model.DatasetModel(sqlReader.GetValue(0).ToString(), sqlReader.GetValue(1).ToString(), sqlReader.GetValue(2).ToString(), sqlReader.GetValue(3).ToString(),
                        sqlReader.GetValue(4).ToString(), sqlReader.GetValue(5).ToString(), sqlReader.GetValue(6).ToString(), sqlReader.GetValue(7).ToString(), sqlReader.GetValue(8).ToString(),
                        sqlReader.GetValue(9).ToString(), sqlReader.GetValue(10).ToString(), sqlReader.GetValue(11).ToString(), sqlReader.GetValue(12).ToString(), sqlReader.GetValue(13).ToString(),
                        sqlReader.GetValue(14).ToString(), sqlReader.GetValue(15).ToString(), sqlReader.GetValue(16).ToString(), sqlReader.GetValue(17).ToString());
                list.Add(readModel);
            }

            List<Model.DatasetModel> sortedList = new List<Model.DatasetModel>();
            sortedList = list.OrderBy(obj => Convert.ToInt32(obj.ID)).ToList();
            listView.Items.Clear();

            foreach (Model.DatasetModel model in sortedList)
            {
                ListViewItem listViewItem = new ListViewItem(model.ID);
                listViewItem.SubItems.Add(model.REF_DATE);
                listViewItem.SubItems.Add(model.GEO);
                listViewItem.SubItems.Add(model.DGUID);
                listViewItem.SubItems.Add(model.Sex);
                listViewItem.SubItems.Add(model.Age_group);
                listViewItem.SubItems.Add(model.Student_response);
                listViewItem.SubItems.Add(model.UOM);
                listViewItem.SubItems.Add(model.UOM_ID);
                listViewItem.SubItems.Add(model.SCALAR_FACTOR);
                listViewItem.SubItems.Add(model.SCALAR_ID);
                listViewItem.SubItems.Add(model.VECTOR);
                listViewItem.SubItems.Add(model.COORDINATE);
                listViewItem.SubItems.Add(model.VALUE);
                listViewItem.SubItems.Add(model.STATUS);
                listViewItem.SubItems.Add(model.SYMBOL);
                listViewItem.SubItems.Add(model.TERMINATED);
                listViewItem.SubItems.Add(model.DECIMALS);
                listView.Items.Add(listViewItem);
            }
            dbAccess.closeConn();
        }

        /// <summary>
        /// Method to call the sql and return the SEX count
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int sexGroupCount(string sexType)
        {
            string sql = "select count(*) from Exercise4 where SEX = @SEX;";
            int count = dbAccess.executeScalar(sql, "SEX", sexType);
            dbAccess.closeConn();

            return count;
        }
        /// <summary>
        /// Method to call the sql and return the Student response count
        /// </summary>
        /// <param name="studentResponse"></param>
        /// <returns></returns>
        public int studentResponseCount(string studentResponse)
        {
            string sql = "select count(*) from Exercise4 where Student_response = @Student_response;";
            int count = dbAccess.executeScalar(sql, "Student_response", studentResponse);
            dbAccess.closeConn();

            return count;
        }
        /// <summary>
        /// Method to call the sql and return the Sex and Student response related count
        /// </summary>
        /// <param name="studentResponse"></param>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int sexAndstudentResponseCount(string studentResponse, string sexType)
        {
            string sql = "select count(*) from Exercise4 where Student_response = @Student_response AND SEX = @SEX;";
            int count = dbAccess.executeScalar(sql, "Student_response", studentResponse, "SEX", sexType);
            dbAccess.closeConn();

            return count;
        }
    }
}
