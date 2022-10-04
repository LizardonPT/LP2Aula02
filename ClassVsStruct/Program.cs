using System;

namespace ClassVsStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Player player1, player2;

            player1 = new Player(10, 10);
            player2 = new Player(10, 10);*/

            Player player1 = new Player() {Health = 10, Armor = 10};
            Player player2 = player1;

            Console.WriteLine($"Player1 => Health: {player1.Health} Armor: {player1.Armor}");
            Console.WriteLine($"Player2 => Health: {player2.Health} Armor: {player2.Armor}");

            player1.Health = 200;
            player1.Armor = 200;

            Console.WriteLine($"Player1 => Health: {player1.Health} Armor: {player1.Armor}");
            Console.WriteLine($"Player2 => Health: {player2.Health} Armor: {player2.Armor}");
            
        }
    }
}
