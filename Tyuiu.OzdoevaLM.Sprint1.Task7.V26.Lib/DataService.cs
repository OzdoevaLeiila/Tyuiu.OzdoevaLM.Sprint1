using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OzdoevaLM.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double s1 = (Math.Sin(Math.Pow(x, 2)) + y) / (y + 1);    
            double s2 = (x * y - 12) / (34 + Math.Pow(x, 2));
            return Math.Round(s1 - s2, 3);
        }
    }
}
