using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportBall volleyball = new SportBall(6, "Volley Ball", SportCategory.Collective)
            {
              Length = 18,
              Width = 9
            };

            SportBall tableTennis = new SportBall(1, "Table Tennis", SportCategory.SinglePlayer)
            {
              Length = 23.7,
              Width = 8.25
            };
            volleyball.SportCharacteristics();
            Console.WriteLine();
            tableTennis.SportCharacteristics();
            Console.ReadKey();
        }
    }
}
