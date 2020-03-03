using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_3.Controller;
using Assignment_3.Model;
using System;

namespace UnitTestProject
{
    /// <summary>
    /// Unit test class 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Unit test method to add a record into dataset
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            DatasetModel dataSetModel = new DatasetModel("31", "2020", "Brazil", "", "Males", "28 years", "Always", 
                "Percent", "239", "units", "0", "v30413290", "1.2.1.5", "31", "", "", "", "0");

            DatasetController controller = new DatasetController();

            try
            {
                Console.WriteLine("Felipe Magnago");
                controller.AddData(dataSetModel);
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, "Error: Could not add data");
                return;
            }

        }
    }
}
