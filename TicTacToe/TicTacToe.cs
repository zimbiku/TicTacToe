using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToe
    {
        private int moveCount;
        private int[,] board;
        private int size;
        /// Created a Tic Tac Tow game board
        /// <param name="boardSize">board is of size nxn</param>
        public TicTacToe(int n)
        {
            board = new int[n, n];  ///new array is initialized with 0's
            moveCount = 0;
            size = n;
        }

        /// &lt;summary&gt;
        /// Place a piece on the game board
        /// &lt;/summary&gt;
        /// &lt;param name=&quot;row&quot;&gt;row to place a piece&lt;/param&gt;
        /// &lt;param name=&quot;col&quot;&gt;column to place a piece&lt;/param&gt;
        /// &lt;param name=&quot;player&quot;&gt;the player (1 or 2) the piece is for&lt;/param&gt;
        /// &lt;returns&gt;0 = no winner, 1 = player 1 won, 2 = player 2 won&lt;/returns&gt;
        public int PlacePiece(int row, int col, int player)
        {
            //player = 1 or 2

            if (board[row,col] == 0)
            {
                board[row,col] = player;
            }
            moveCount++;

            //check the row
            for (int a = 0; a < size; a++)
            {
                //only need to check the row which the player guessed
                if (board[a, col] != player)
                {
                    //found a point for the other player or empty
                    break;
                }

                if (a == size - 1)
                {
                    return player;
                }
            }

            //check the col, and only need to check for what they just guessed
            for (int a = 0; a < size; a++)
            {
                if (board[row,a] != player)
                {
                    //found a point for the other player or empty
                    break;
                }
                if (a == size - 1)
                {
                    return player;
                }
            }

            //check diagonal   /
            if (row == col)
            {
                for (int i = 0; i < size; i++)
                {
                    if (board[i, i] != player)
                    {
                        //found a no match
                        break;
                    }
                    if (i == size - 1)
                    {
                        return player;
                    }
                }
            }

            //check other diag    \
            if (row + col == size - 1)
            {
                for (int a = 0; a < size; a++)
                {
                    if (board[a, (size - 1) - a] != player)
                    {
                        break;
                    }
                    if (a == size - 1)
                    {
                        return player;
                    }
                }
            }

            //draw - no more moves
            if (moveCount == Math.Pow(size, 2))
            {
                //I added a pure draw condition as it wasnt in the description but it can happen.
                return 3;
            }

            return 0;
        }

        public int getPlayer(int p)
        {
            if (p == 1) return 2;
            if (p == 2) return 1;
            return 0;
        }
    }
}
