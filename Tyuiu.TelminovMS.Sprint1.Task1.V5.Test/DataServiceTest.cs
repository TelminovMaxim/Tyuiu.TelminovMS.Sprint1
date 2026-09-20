using Tyuiu.TelminovMS.Sprint1.Task1.V5.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 5.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(10, res);
        }
    }
}
