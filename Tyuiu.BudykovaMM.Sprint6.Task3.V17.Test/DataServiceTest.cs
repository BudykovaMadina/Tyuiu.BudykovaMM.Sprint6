using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task3.V17.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
            {
                { 22,  32, -16,  24,  27 },
                { 3,  -20,  24, -20,  25 },
                { 21,  17,  -8, -19,  17 },
                { 8,   22,  28,  27,  19 },
                { 11,  20,  12,  27,  29 }
            };

            int[,] result = ds.Calculate(matrix);


            int[] fourthCol = { result[0, 3], result[1, 3], result[2, 3], result[3, 3], result[4, 3] };

            
            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(fourthCol[i] <= fourthCol[i + 1]);
            }
        }
    }
}
