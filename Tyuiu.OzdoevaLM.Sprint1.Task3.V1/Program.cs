using Tyuiu.OzdoevaLM.Sprint1.Task3.V1.Lib;

//Объявите необходимые переменные и напишите программу вычисления объема цилиндра, предполагающий ввод исходных данных.

namespace Tyuiu.OzdoevaLM.Sprint1.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Оздоева Л. М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите радиус цилиндра:");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту цилиндра:");
            double h = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Радиус цилиндра = " + r);
            Console.WriteLine("Высота цилиндра = " + h);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объём цилиндра = " + ds.CylinderVolume(r, h));

            Console.ReadKey();
        }
    }
}
