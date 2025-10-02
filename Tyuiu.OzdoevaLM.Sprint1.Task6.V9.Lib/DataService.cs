using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.OzdoevaLM.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            string result = "";
            foreach (string word in value.Split())

                result += word[word.Length - 1] + word.Remove(word.Length - 1) + " ";
            return result.Trim();
        }
    }
}
