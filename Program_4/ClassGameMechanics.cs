using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    internal class ClassGameMechanics
    {
        // declarations
        char[,] map;
        byte srow = 0;
        byte scol = 0;
        int alternate = 0;
        string printmap = "";
        string guess = "";

        /// <summary>
        /// creates the map and randomizes the position of where the island.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public ClassGameMechanics(int row, int column)
        {
            // gets users input on row and column
            map = new char[row, column];

            // random
            Random rand = new Random();
            srow = (byte)rand.Next(0, map.GetLength(0));
            scol = (byte)rand.Next(0, map.GetLength(1));

            // 2d array printing ~ based on user input
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = '~';
                }
            }
        }

        /// <summary>
        /// prints the map
        /// </summary>
        /// <returns></returns>
        public string PrintMap()
        {
            byte count = 0;

            // resets the map everytime it is printed
            printmap = "";

            // counts the number 
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (count == 15)
                {
                    count = 0;
                }
                printmap += count.ToString() + " ";
                count++;
            }

            printmap += "\n";
            // prints the map
            for (int j = 0; j < map.GetLength(0); j++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    printmap += map[j, k].ToString();
                    printmap += " ";
                }
                // prints the column
                printmap += (j + ((j < 16) ? " " : " ")).ToString() + "\n";
            }
            return printmap;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowGuess"></param>
        /// <param name="columnGuess"></param>
        /// <returns></returns>
        public string GuessMap(int rowGuess, int columnGuess)
        {
            guess = "";

            // island is found if guess and secret is the same
            if ((rowGuess == srow) && (columnGuess == scol))
            {

                map[rowGuess, columnGuess] = 'I';
                guess = PrintMap();
                MessageBox.Show("You found the Island!", "Winner",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

                // reset the map
                printmap = "";

            }
            else if (alternate % 2 == 0)
            {
                // increment to one so next time it will give you east and west
                alternate++;
                if (rowGuess < srow)
                {
                    map[rowGuess, columnGuess] = 'S';
                    guess = PrintMap();
                }
                else if (rowGuess > srow)
                {
                    map[rowGuess, columnGuess] = 'N';
                    guess = PrintMap();
                }
                else
                {
                    map[rowGuess, columnGuess] = 'R';
                    guess = PrintMap();
                }
            }
            else
            {
                // decrease to 0 so it gets south and north next time
                alternate--;
                if (columnGuess < scol)
                {
                    map[rowGuess, columnGuess] = 'E';
                    guess = PrintMap();
                }
                else if (columnGuess > scol)
                {
                    map[rowGuess, columnGuess] = 'W';
                    guess = PrintMap();
                }
                else
                {
                    map[rowGuess, columnGuess] = 'C';
                    guess = PrintMap();
                }

            }
            return guess;
        }
    }
}
