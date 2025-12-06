using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BudykovaMM.Sprint6.Task2.V7.Lib;
using System;

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

            
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = -9.10;   // x = -5
            valueWaitArray[1] = 1.55;    // x = -4
            valueWaitArray[2] = 292.78;  // x = -3
            valueWaitArray[3] = -0.57;   // x = -2
            valueWaitArray[4] = -0.35;   // x = -1
            valueWaitArray[5] = 2.00;    // x = 0
            valueWaitArray[6] = 4.35;    // x = 1
            valueWaitArray[7] = 4.57;    // x = 2
            valueWaitArray[8] = -288.78; // x = 3
            valueWaitArray[9] = 2.45;    // x = 4
            valueWaitArray[10] = 13.10;  // x = 5

            
            double[] res = ds.GetMassFunction(startValue, stopValue);

            
            for (int i = 0; i < len; i++)
            {
                
                double roundedRes = Math.Round(res[i], 2);

                
                Assert.AreEqual(valueWaitArray[i], roundedRes, 0.001,
                    $"Ошибка при x={startValue + i}. Ожидалось: {valueWaitArray[i]}, Получено: {res[i]} (округляется до {roundedRes})");
            }
        }
    }
}
