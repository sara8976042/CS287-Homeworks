using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("建立第一隻寶可夢");

            Pokemon Pokemon1 = new Pokemon();

            Console.Write("請輸入National No:");
            try
            {
                Pokemon1.nationalNo = int.Parse(Console.ReadLine());
            } catch {
                Console.WriteLine("National NO 輸入錯誤");
            }

            Console.Write("請輸入Type:");
            try
            {
                Pokemon1.Type = Console.ReadLine();
            } catch {
                Console.WriteLine("Type 輸入錯誤");
            }

            Console.Write("請輸入Species:");
            try
            {
                Pokemon1.Species = Console.ReadLine();
            } catch {
                Console.WriteLine("Species 輸入錯誤");
            }

            Console.Write("請輸入Height:");
            try
            {
                Pokemon1.Height = float.Parse(Console.ReadLine());
            } catch {
                Console.WriteLine("Heigh 輸入錯誤");
            }


            Console.Write("請輸入Weight:");
            try
            {
                Pokemon1.Weight = float.Parse(Console.ReadLine());
            } catch {
                Console.WriteLine("Weight 輸入錯誤");
            }

            Console.Write("請輸入Abilities:");
            try
            {
                Pokemon1.Abilities = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Abilities 輸入錯誤");
            }

            Console.Write("請輸入Local No:");
            try { 
                Pokemon1.LocalNo = int.Parse(Console.ReadLine());
            }catch{
                Console.WriteLine("Local No 輸入錯誤");
            }

            Console.Write("請輸入Japanese:");
            try
            {
                Pokemon1.Japanese = Console.ReadLine();
            }catch
            {
                Console.WriteLine("Japanese 輸入錯誤");
            }

            Console.WriteLine("您輸入的資料如下：");
            Console.WriteLine("National No:{0}", Pokemon1.nationalNo);
            Console.WriteLine("Type:{0}", Pokemon1.Type);
            Console.WriteLine("Species:{0}", Pokemon1.Species);
            Console.WriteLine("Heigh:{0}", Pokemon1.Height);
            Console.WriteLine("Weight:{0}", Pokemon1.Weight);
            Console.WriteLine("Abilities:{0}", Pokemon1.Abilities);
            Console.WriteLine("Local No:{0}", Pokemon1.LocalNo);
            Console.WriteLine("Japanese:{0}", Pokemon1.Japanese);


        }
    }
}
