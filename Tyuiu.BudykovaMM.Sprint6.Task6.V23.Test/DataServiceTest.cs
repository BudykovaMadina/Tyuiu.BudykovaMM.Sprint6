using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task6.V23.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidChecked()
        {
            string file = "InPutDataFileTask6V23.txt";
            string directory = @"C:\DataSprint6";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
