using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = 5;
            int cols = 5;

            
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    if (matrix[j, 3] > matrix[j + 1, 3])
                    {
                        
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = temp;
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
