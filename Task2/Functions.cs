using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Functions
    {
        public static Dictionary<string, int> UniqueWords(string str)
        {
            str = str.ToLower();
            var words = str.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            var res = new Dictionary<string, int>();
            foreach (var w in words)
            {
                if (res.ContainsKey(w))
                {
                    res[w]++;
                }
                else
                {
                    res.Add(w, 1);
                }
            }
            return res;
        }
        public static void DictionaryPrint(Dictionary<string, int> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
