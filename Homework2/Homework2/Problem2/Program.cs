using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建立第一個商品");

            Product Product1 = new Product();

            Console.Write("請輸入ID:");
            try
            {
                Product1.Id = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ID 輸入錯誤");
            }

            Console.Write("請輸入 Name:");
            try
            {
                Product1.Name = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Name 輸入錯誤");
            }

            Console.Write("請輸入 Price:");
            try
            {
                Product1.Price =int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Price 輸入錯誤");
            }

            Console.Write("請輸入 Categories:");
            try
            {
                Product1.Categories = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Categories 輸入錯誤");
            }

            Console.WriteLine("您輸入的資料如下：");
            Console.WriteLine("ID:{0}", Product1.Id);
            Console.WriteLine("Name:{0}", Product1.Name);
            Console.WriteLine("Price:{0}", Product1.Price);
            Console.WriteLine("Categories:{0}", Product1.Categories);
        }
    }
}
