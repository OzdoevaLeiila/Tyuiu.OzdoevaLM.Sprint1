using Tyuiu.OzdoevaLM.Sprint1.Task6.V9.Lib;

namespace Tyuiu.OzdoevaLM.Sprint1.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string strTest = "hello world program";
            string res = ds.MoveLetterToStart(strTest);
            string wait = "ohell dworl mprogra";

            Assert.AreEqual(wait, res);
        }
    }
}
