using Tyuiu.TelminovMS.Sprint1.Task2.V23.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 5;
            var res = ds.ConvertMinutesToSeconds(a);
            Assert.AreEqual(300, res);

        }
    }
}
