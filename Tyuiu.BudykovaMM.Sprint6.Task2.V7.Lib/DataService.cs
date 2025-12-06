using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task2.V7.Lib
{
    public class DataService : ISprint6Task2V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                
                double denominator = Math.Cos(x) + 1;
                if (Math.Abs(denominator) < 1e-12)
                {
                    y = 0;
                }
                else
                {
                    
                    y = 3 * x + 2 - x / denominator;

                    y = Math.Round(y, 2, MidpointRounding.AwayFromZero);
                }

                valueArray[count] = y;
                count++;
            
        }
            return valueArray;
        }
    }
}
