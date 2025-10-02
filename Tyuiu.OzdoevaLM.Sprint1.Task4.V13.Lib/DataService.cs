using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OzdoevaLM.Sprint1.Task4.V13.Lib
{
    public class DataService : ISprint1Task4V13
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(Math.Cos(Math.PI / x) / (3 * Math.Exp(x + y)), 3);
            return res;
        }
    }
}
