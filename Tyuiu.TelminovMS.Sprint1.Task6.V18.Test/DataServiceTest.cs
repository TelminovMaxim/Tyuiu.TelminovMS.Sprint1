using Tyuiu.TelminovMS.Sprint1.Task6.V18.Lib;

namespace Tyuiu.TelminovMS.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string strTest = "123";

            bool res = ds.CheckNumber(strTest);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
