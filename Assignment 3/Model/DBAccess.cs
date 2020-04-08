/*
* Felipe Magnago - 040915490
* Programming Language Research Project - Final Project
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Assignment_3.Model
{
    /// <summary>
    /// Class to connect to the database and execute the query
    /// </summary>
    public class DBAccess
    {
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();

        private static string strConnString = "Data Source=(local);Initial Catalog='Programming Language Research';Integrated Security=True";


        /// <summary>
        /// Method to create the connection with the database
        /// </summary>
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to close the connection with the database
        /// </summary>
        public void closeConn()
        {
            connection.Close();
        }

        /// <summary>
        /// Method do execute the data adapter
        /// </summary>
        /// <param name="tblName"></param>
        /// <param name="strSelectSql"></param>
        /// <returns></returns>
        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);


                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();


                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to read through data adapter
        /// </summary>
        /// <param name="query"></param>
        /// <param name="tblName"></param>
        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to read data from data source
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public SqlDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SqlDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Method to execute the query
        /// </summary>
        /// <param name="dbCommand"></param>
        /// <returns></returns>
        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Method to execute the query and return a scalar value
        /// </summary>
        /// <param name="sqlQuery"></param>
        /// <param name="parameter"></param>
        /// <param name="parameterValue"></param>
        /// <param name="parameter2"></param>
        /// <param name="parameterValue2"></param>
        /// <returns></returns>
        public int executeScalar(string sqlQuery, string parameter, string parameterValue, 
            string parameter2 = "default parameter" , string parameterValue2 = "default parameter value")
        {
            Int32 newCount = 0;
            string sql = sqlQuery;
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@"+parameter, SqlDbType.VarChar);
                cmd.Parameters["@"+parameter].Value = parameterValue;
                if (!parameter2.Equals("default parameter"))
                {
                    cmd.Parameters.Add("@" + parameter2, SqlDbType.VarChar);
                    cmd.Parameters["@" + parameter2].Value = parameterValue2;
                }
                try
                {
                    conn.Open();
                    newCount = (Int32)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return (int)newCount;
        }

    }
}
