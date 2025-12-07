using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task4.V23.Lib
{
    public class DataService : ISprint6Task4V23
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
                if ((2 * x - 2) == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = 4-2*x+(2+Math.Cos(x))/(2*x-2);
                    valueArray[count] = y;
                    valueArray[count] = Math.Round(y, 2);
                }

                count++;

            }
            return valueArray;
        }
    }
}
