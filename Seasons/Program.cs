using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*輸入月份1~12月，利用switch判斷相對應的季節春、夏、秋、冬並印出。若不在此範圍則印出”輸入錯誤”。*/
            int month;
            Console.WriteLine("利用switch判斷相對應的季節春、夏、秋、冬");
            Console.WriteLine("請輸入月份");

            var monthStr = Console.ReadLine();
            month = !IsInteger(monthStr) ? 99 : int.Parse(monthStr);

            Console.WriteLine((month > 12 || month <= 0) ? "輸入錯誤" : MonthLine(month));
            Console.Read();
        }

        static string MonthLine(int month)
        {
            int result = Convert.ToInt16(Math.Ceiling(month / 3f) - 1);

            switch (result)
            {
                case 0:
                    return "春";
                case 1:
                    return "夏";
                case 2:
                    return "秋";
                case 3:
                    return "冬";
            }
            return "錯誤";
        }
        static bool IsInteger(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
