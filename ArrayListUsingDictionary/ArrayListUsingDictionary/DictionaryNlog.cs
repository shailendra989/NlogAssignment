using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListUsingDictionary
{
    internal class DictionaryNlog
    {
        public void ShowDemo()

        {
            try
            {
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(1, "Shivam");
                dic.Add(2, "Riya");
                dic.Add(3, "shailendra");
                foreach (KeyValuePair<int, string> pair in dic)
                {
                    Console.WriteLine(element.Key, element.pair);
                }

                if (dic.Remove(1))
                {
                    Console.WriteLine("removed");
                }
                else
                {
                    Console.WriteLine("not removed");
                }
                dic.Add(4, "sanu");

                foreach (KeyValuePair<int, string> element in dic)
                {
                    Console.WriteLine(element.Key, element.Value);
                }

            }
             catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
