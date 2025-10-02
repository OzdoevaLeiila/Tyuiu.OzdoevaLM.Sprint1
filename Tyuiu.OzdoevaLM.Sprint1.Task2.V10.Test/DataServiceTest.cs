using Tyuiu.OzdoevaLM.Sprint1.Task2.V10.Lib;

namespace Tyuiu.OzdoevaLM.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int metr = 6;
            var res = ds.ConvertMetreToInchs(metr);
            Assert.AreEqual(236.221, res);
        }
    }
}
