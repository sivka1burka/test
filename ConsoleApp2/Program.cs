using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bank
    {
        private int Money;
        public int money {
            get 
            {
                return Money; 
            } set 
            {
                Money = value;
                Task save = Task.Run(() => { Save(); });
                save.Wait();
            } }
        private string Name;
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                Task save = Task.Run(() => { Save(); });
                save.Wait();
            }
        }
        private int Percent;
        public int percent
        {
            get
            {
                return Percent;
            }
            set
            {
                Percent = value;
                Task save = Task.Run(() => { Save(); });
                save.Wait();
            }
        }
        public void Save()
        {
            
            string path = @"log.txt";
            
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(money+" | "+name+" | "+percent);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.money = 2000;
            bank.name = "abobus";
            bank.percent = 1111;
        }
    }

}
