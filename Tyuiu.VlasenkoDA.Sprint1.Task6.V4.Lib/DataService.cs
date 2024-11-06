using System;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VlasenkoDA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            // Регулярное выражение для поиска слов с удвоенной буквой "н"
            string pattern = @"\b[\p{L}]*нн[\p{L}]*\b"; // \p{L} - любые буквы

            // Ищем все совпадения
            MatchCollection matches = Regex.Matches(value, pattern, RegexOptions.IgnoreCase);

            // Если совпадения найдены, возвращаем их через запятую
            if (matches.Count > 0)
            {
                return string.Join(", ", matches.Cast<Match>().Select(m => m.Value));
            }
            else
            {
                return "Слов с удвоенной буквой 'н' не найдено.";
            }
        }
    }
}