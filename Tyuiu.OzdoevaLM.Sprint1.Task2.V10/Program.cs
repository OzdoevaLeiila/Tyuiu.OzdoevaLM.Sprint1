using Tyuiu.OzdoevaLM.Sprint1.Task2.V10.Lib;
//Формулировка задания: Известно расстояние в метрах. Вычислить расстояние в дюймах. Ответ округлите до 3 знаков после запятой.
//Что пользователь вводит? Расстояние в метрах (целое число)
//Что программа печатает на экране? Расстояние в дюймах (вещественное число)


namespace Tyuiu.OzdoevaLM.Sprint1.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Оздоева Л. М. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнила: Оздоева Лейла Магомедовна | ИИПб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int metr;

            Console.WriteLine("Введите расстояние в метрах");
            metr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние в дюймах = " + ds.ConvertMetreToInchs(metr));

            Console.ReadLine();
        }
    }
}
