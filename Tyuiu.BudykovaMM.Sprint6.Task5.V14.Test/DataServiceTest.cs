using Tyuiu.BudykovaMM.Sprint6.Task5.V14.Lib;
using System.IO;
namespace Tyuiu.BudykovaMM.Sprint6.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidChecked()
        {
            string file = "InPutDataFileTask5V14.txt";
            string directory = @"C:\DataSprint6";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
