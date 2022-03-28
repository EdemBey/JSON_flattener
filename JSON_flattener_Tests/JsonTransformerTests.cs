using System;
using System.IO;
using JSON_flattener;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JSON_flattener_Tests
{
    [TestClass()]
    public class JsonTransformerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void GetPropertiesFromJsonTest_FileNotFound()
        {
            var file_name = "text.json"; //filename misspelled on purpose
            JsonTransformer.GetPropertiesFromJson(file_name);
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPropertiesFromJsonTest_FileEmpty()
        {
            var file_name = "empty_test.json";
            JsonTransformer.GetPropertiesFromJson(file_name);
            Assert.Fail();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void GetPropertiesFromJsonTest_NotJsonFormat()
        {
            //file used for testing is empty by default
            var file_name = "notJson_test.json";
            JsonTransformer.GetPropertiesFromJson(file_name);
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPropertiesFromJsonTest_Working()
        {
            string file_name = "test.json";
            var dic= JsonTransformer.GetPropertiesFromJson(file_name);
            Assert.AreEqual(dic.Count,4);
        }
    }
}