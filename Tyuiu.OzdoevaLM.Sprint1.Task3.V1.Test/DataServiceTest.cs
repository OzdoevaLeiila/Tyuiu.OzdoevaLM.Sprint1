using Tyuiu.OzdoevaLM.Sprint1.Task3.V1.Lib;

namespace Tyuiu.OzdoevaLM.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 3;
            double h = 5;
            double wait = 141.372;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(wait, res);

        }
    }
}
