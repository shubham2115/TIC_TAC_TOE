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
    }
}
