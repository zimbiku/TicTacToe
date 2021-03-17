using System;
using TicTacToe;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the board: ");
            // I AM ASSUMING YOU ONLY ENTER AN INTEGER.  NORMAL TYPE CHECKING WOULD BE NEEDED IN THE REAL WORLD.
            int n = int.Parse(Console.ReadLine());
            TicTacToe game = new TicTacToe(n);

            Console.WriteLine("Welcome to tic tac toe.");
            Console.WriteLine("Your entries must be in the form of 'x,y'.");
            //I ASSUME THAT YOU DON'T TRY AND BREAK THE GAME AS I DID NOT PUT OUT OF BOUNDS CHECKS IN.  THIS WASNT DONE TO SAVING TIME.
            //the board starts at 0,0 and goes to n-1,n-1 - yes I could pretty this up to make it easier but for sake of proving it works i left it as is.

            int player = 2;  //i will flip this to 1 to start in the do loop.
            int win = 0;

            do
            {
                player = game.getPlayer(player);  //swap the player to the next position
                Console.WriteLine($"Player {player}, please enter your move:");
                string move = Console.ReadLine();

                win = game.PlacePiece(int.Parse(move.Substring(0, 1)), int.Parse(move.Substring(2, 1)), player);
            } while (win == 0);

            if (win != 3)
            {
                Console.WriteLine($"Player {player} won.");
            }
            else
            {
                Console.WriteLine($"It was a draw.");
            }

        }
    }
}
