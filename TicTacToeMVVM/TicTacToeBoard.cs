﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TicTacToeMVVM{
    class TicTacToeBoard
    {
        private const int _boardSize = 3;
        private char[] _pieces = { 'x', 'o' };
        private char[,] _board = new char[_boardSize, _boardSize];

        private int[] _magicBox = {2, 7, 6, 9, 5, 1, 4, 3, 8};
        public char[,] Board
        {
            get { return _board; }
        }

        public char[] Pieces
        {
            get { return _pieces; }
        }

        public Boolean setPiece(char c, int row, int col)
        {
            if (validInput(c, row, col) && positionFree(row, col))
            {
                _board[row, col] = c;
                return true;
            }
            else return false;

        }
        
        private bool positionFree(int row, int col)
        {
            if (_board[row, col] == '\0') return true;
            return false;
        }

        private bool validInput(char c, int row, int col)
        {
            if (Pieces.Contains(c))
            {
                if (row >= 0 && row < _boardSize)
                {
                    if (col >= 0 && col < _boardSize)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
