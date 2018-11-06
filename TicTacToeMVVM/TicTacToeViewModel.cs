using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TicTacToeMVVM
{
    class TicTacToeViewModel
    {
        private ICommand mButtonCommand;
        TicTacToeGame g = new TicTacToeGame();

        public ICommand ButtonCommand
        {
            get { return mButtonCommand; }

            set { mButtonCommand = value; }
        }

        public TicTacToeViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(g.playPiece(g.CurrentPlayer.Piece, )));
        }

        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }
}
