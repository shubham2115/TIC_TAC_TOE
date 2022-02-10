using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_toe
{
    public class Board
    {


        char[] board = new char[10];
        public void gameBoard()
        {

            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
        }
            public void abillityToInput()
            {
                Console.WriteLine("Enter you Choice from O/X :");
                char playerChoice = Convert.ToChar(Console.ReadLine());
                if (playerChoice == 'X')
                {
                    Console.WriteLine("Player Chose " + playerChoice);
                    Console.WriteLine("Computer Chose " + O);
                }
                else if (playerChoice == 'O')
                {
                    Console.WriteLine("Player Chose " + playerChoice);
                    Console.WriteLine(" Computer Chose " + X);
                }
                else
                {
                    Console.WriteLine("Entered invalid input  ");
                }
            }
        
    }
}
