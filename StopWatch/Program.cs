using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 Segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto Tempo deseja contar ?");


            string data = Console.ReadLine().ToLower();
            // pega o ultimo char da string
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            // pega todos elementos da string menos o ultimo
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            //Sair da aplicação
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
