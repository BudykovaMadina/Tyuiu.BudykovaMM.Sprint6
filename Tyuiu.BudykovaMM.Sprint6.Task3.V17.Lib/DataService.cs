using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Копируем матрицу
            int[,] result = (int[,])matrix.Clone();

            // Извлекаем 4-й столбец
            int[] fourthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fourthColumn[i] = result[i, 3];
            }

            // Сортируем 4-й столбец
            Array.Sort(fourthColumn);

            // Записываем отсортированный столбец обратно
            for (int i = 0; i < rows; i++)
            {
                result[i, 3] = fourthColumn[i];
            }

            return result;
        }
    }
}
