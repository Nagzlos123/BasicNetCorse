using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Kata
    {
        public static string Join(List<string> list, char seperator)
        {
            StringBuilder sb = new StringBuilder();
           
            for (int i = 0; i < list.Count - 1; i++)
            {
                sb.Append(list[i]);
                if(i != list.Count - 1)
                {
                    sb.Append(seperator);
                }
            }
            return sb.ToString();
        }
        public static List<string> Revers(List<string> list)
        {
            var result = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }

            return result;
        }
        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1;
                }else if (i == input.Length - 1)
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }
            }

            return result;
        }
        public static string ReverseWords(string str)
        {
            //var splitWords = Split(str, ' ');
            var splitWords = str.Split( ' ');
            //var reversWords = Revers(splitWords);
            var reversWords = splitWords.Reverse();
            //var result = Join(reversWords, ' ');
            var result = string.Join(" ", reversWords);
            return result;
        }
    }
}
