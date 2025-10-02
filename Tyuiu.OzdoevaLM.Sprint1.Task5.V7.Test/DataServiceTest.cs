using Tyuiu.OzdoevaLM.Sprint1.Task5.V7.Lib;


namespace Tyuiu.OzdoevaLM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90;
            int res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);
        }
    }
}
