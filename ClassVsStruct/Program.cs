using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() { Health = 20, Armor = 10 };
            Player player2 = player1;

            Console.WriteLine($"Player 1: Health = {player1.Health}, Armor = {player1.Armor}");
            Console.WriteLine($"Player 2: Health = {player2.Health}, Armor = {player2.Armor}");

            player1.Health = 50;
            player1.Armor = 30;

            Console.WriteLine("\nAfter modifying Player 1:");
            Console.WriteLine($"Player 1: Health = {player1.Health}, Armor = {player1.Armor}");
            Console.WriteLine($"Player 2: Health = {player2.Health}, Armor = {player2.Armor}");
        }
    }
}
