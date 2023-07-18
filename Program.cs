using System;


namespace Bee1046 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour_in, hour_out, time;

            string[] Game = Console.ReadLine().Split(' ');
            hour_in = int.Parse((Game[0]));
            hour_out = int.Parse((Game[1]));

            time = 24;

            if (hour_in > hour_out) // inicio maior que o fim 2 > 10
            {
                time = time - hour_in + hour_out;// time = 16-2 = 14 e 24-14 = 10 HORAS
                Console.WriteLine("O JOGO DUROU " + time + " HORA(S)");

            }
            else if (hour_in < hour_out) // 2 menor que 16
            {
                time = hour_out - hour_in;//time = 16 - 2 
                Console.WriteLine("O JOGO DUROU " + time + " HORA(S)");
            }
            else if  (hour_in == 0 && hour_out == 0)
            {
                Console.WriteLine("O JOGO DUROU " + time + " HORA(S)");

            }
        }
    }
}




