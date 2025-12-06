using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + 1 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = 3 * x + 2 - x / (Math.Cos(x) + 1);
                    valueArray[count] = y;
                }
                count++;

            }
            return valueArray;
        }
    }
}
