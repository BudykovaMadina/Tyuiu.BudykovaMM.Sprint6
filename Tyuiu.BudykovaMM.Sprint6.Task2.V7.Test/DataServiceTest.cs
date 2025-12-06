using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task2.V7.Lib;

namespace Tyuiu.BudykovaMM.Sprint6.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            // Ожидаемые значения (уже округлённые до 2 знаков)
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = -9.1;     // -9.10
            valueWaitArray[1] = 1.55;     // 1.55
            valueWaitArray[2] = 292.78;   // 292.78
            valueWaitArray[3] = -0.57;    // -0.57
            valueWaitArray[4] = -0.35;    // -0.35
            valueWaitArray[5] = 2.0;      // 2.00
            valueWaitArray[6] = 4.35;     // 4.35
            valueWaitArray[7] = 4.57;     // 4.57
            valueWaitArray[8] = -288.78;  // -288.78
            valueWaitArray[9] = 2.45;     // 2.45
            valueWaitArray[10] = 13.1;    // 13.10

            double[] res = ds.GetMassFunction(startValue, stopValue);

            // Проверяем точное совпадение (после округления в методе)
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}