using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task7.V12.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMethod()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint6\InPutDataFileTask7V12.csv";

            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int colums = lines[0].Split(';').Length;

            int[,] waitArray = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    waitArray[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            int waitRow = waitArray.GetUpperBound(0) + 1;
            for (int r = 0; r < waitRow; r++)
            {
                if (waitArray[r, 8] != 10)
                {
                    waitArray[r, 8] = 0;
                }
            }

            int[,] resArr = ds.GetMatrix(path);

            CollectionAssert.AreEqual(waitArray, resArr);
        }
    }
}
