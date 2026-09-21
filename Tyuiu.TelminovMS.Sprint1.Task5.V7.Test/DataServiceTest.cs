using Tyuiu.TelminovMS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(3, res);
        }
    }
}
