using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string email = "user123@gmail.com"; // 定義一個電子郵件地址
                bool result = email.StartsWith("gmail.com"); // 判斷電子郵件是否以 'gmail.com' 開頭
                string output = result
                    ? "電子郵件是來自 'gmail.com'"
                    : "電子郵件不是來自 'gmail.com'"; // 根據結果決定輸出訊息

                Console.WriteLine(output); // 輸出結果
                Console.WriteLine(); // 輸出空行
        
        }
    }
}
