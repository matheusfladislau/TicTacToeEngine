using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsGame {
    public class GameEndedEventArgs : EventArgs {
        public bool PlayAgain { get; set; }
    }
}
