using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BudykovaMM.Sprint6.Task6.V23.Lib
{
    public class DataService : ISprint6Task6V23
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] words = line.Split(
                        new[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    foreach (string word in line.Split())
                    {
                        if (word.Contains('s'))
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
