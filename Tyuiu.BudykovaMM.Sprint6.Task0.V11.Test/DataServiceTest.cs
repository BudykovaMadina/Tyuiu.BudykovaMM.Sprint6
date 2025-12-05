using System.IO;
using Tyuiu.BudykovaMM.Sprint6.Task0.V11.Lib;
namespace Tyuiu.BudykovaMM.Sprint6.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 18.4;
            Assert.AreEqual(wait, res);
        }
    }
}
