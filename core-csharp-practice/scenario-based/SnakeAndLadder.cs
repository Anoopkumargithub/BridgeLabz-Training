using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.senariobased
{
    internal class SnakeAndLadder
    {
        static int RollDice()
        {
            return new Random().Next(1, 7); // return numbers between 1 to 6
        }

        static int PlayerTurn(string playerName, int position)
        {
            Console.WriteLine(playerName + " turn. Press ENTER to roll dice");
            Console.ReadLine();

            int dice = RollDice();
            Console.WriteLine(playerName + " rolled: " + dice);

            int newPos = position + dice;

            if (newPos > 100)
            {
                Console.WriteLine("Move skipped (greater than 100)");
                return position;
            }

            newPos = CheckSnakeOrLadder(newPos);

            Console.WriteLine(playerName + ": Old Position " + position + " New Position " + newPos);
            return newPos;
        }

        static int CheckSnakeOrLadder(int position)
        {
            switch (position)
            {
                // Ladders
                case 3: return 22;
                case 5: return 8;
                case 11: return 26;

                // Snakes
                case 17: return 4;
                case 19: return 7;
                case 21: return 9;

                default:
                    return position;
            }
        }

        static void Main(string[] args)
        {
            int player1Pos = 0;
            int player2Pos = 0;
            int player3Pos = 0;
            int player4Pos = 0;
            bool gameOver = false;

            while (!gameOver)
            {
                player1Pos = PlayerTurn("Player 1", player1Pos);
                if (player1Pos == 100)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }

                player2Pos = PlayerTurn("Player 2", player2Pos);
                if (player2Pos == 100)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }

                player3Pos = PlayerTurn("Player 3", player3Pos);
                if (player3Pos == 100)
                {
                    Console.WriteLine("Player 3 Wins!");
                    break;
                }

                player4Pos = PlayerTurn("Player 4", player4Pos);
                if (player4Pos == 100)
                {
                    Console.WriteLine("Player 4 Wins!");
                    break;
                }
            }

            Console.WriteLine("Game Over");
        }

    }
}
