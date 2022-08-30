using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo str;
            Console.WriteLine("Ожидайте!!!");
            Random rand = new Random();
            Thread.Sleep(rand.Next(1000, 3000));
            DateTime start = DateTime.Now;
            int startMilSec = start.Second * 1000 + start.Millisecond;
            Console.WriteLine("Нажмите X!!!");
            str = Console.ReadKey(true);
            
            
            if (str.Key.ToString() == "X")
            {
                DateTime finish = DateTime.Now;
                int finishMilSec = finish.Second * 1000 + finish.Millisecond;
                int result = finishMilSec - startMilSec;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Нажата неправильная кнопка!");
            }
                   
                    
           
            
            
        }
    }
}
