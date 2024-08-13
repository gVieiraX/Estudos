using System;
using System.Threading;

namespace StopWatch{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1,1));
            Console.WriteLine(data);
            Console.WriteLine(type);

            

        }
        static void Start(int time)
        {
            int currentTime = 0;
          
            while(currentTime != time){
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("StopWatch finished");
            Thread.Sleep(2500);
        }
    }
}
