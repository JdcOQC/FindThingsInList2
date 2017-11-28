using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThingsInList2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> a = new List<String>();
            a.Add("心與浮云閑");
            a.Add("感物動我心");
            a.Add("拔劍四顧心茫然");
            a.Add("傾心美酒盡玉碗");
            a.Add("貴賤結交心不移");

            for(int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();

            // 請用程式數數看，有幾句詩第一個字是「心」
            // 提示: https://msdn.microsoft.com/zh-tw/library/baketfxw(v=vs.110).aspx
            int count_first = 0;

            Console.WriteLine("有 {0} 句詩第一個字是「心」", count_first);

            // 請用程式數數看，有幾句詩最後一個字是「心」
            // 提示: https://msdn.microsoft.com/zh-tw/library/2333wewz(v=vs.110).aspx
            int count_last = 0;

            Console.WriteLine("有 {0} 句詩最後一個字是「心」", count_last);

            // 請用程式數數看，有幾句詩裡面有「心」，但不是第一個字，也不是最後一個字
            int count_middle = 0;

            Console.WriteLine("有 {0} 句詩裡面有「心」，但不是第一個字，也不是最後一個字", count_middle);

            Console.ReadKey();
        }
    }
}
