using System;

namespace ConvertentoTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            //real = inteiro; //100
            //inteiro = (int)real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);

            inteiro = Convert.ToInt32(real);

            //Console.WriteLine(inteiro);
            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean(255));


        }
    }
}
