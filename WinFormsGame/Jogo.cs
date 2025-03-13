using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsGame {
    public partial class Jogo : Form {
        private readonly TicTacToeEngine _engine;

        public event EventHandler<GameEndedEventArgs> GameEnded;

        public Jogo(TicTacToeEngine engine) {
            this._engine = engine;
            InitializeComponent();
        }

        private void Jogo_Load(object sender, EventArgs e) {
            _engine.Start();
            AtualizarLabel();
        }

        private void AtualizarLabel() {
            lblJogador.Text = "Jogador atual: " + _engine.GetCurrentPlayerSymbol();
        }

        private void ButtonClick(object sender, EventArgs e) {
            var button = sender as Button;

            _engine.SubstituteFieldMatrix(int.Parse(button.Text));
            button.Text = _engine.GetCurrentPlayerSymbol();
            button.ForeColor = Color.Black;
            button.Enabled = false;

            ProximoRound();
        }

        private void ProximoRound() {
            _engine.NextRound();

            if (!_engine.Ended()) {
                AtualizarLabel();
                return;
            }

            lblJogador.Text = "";
            var result = MessageBox.Show($"{_engine.Result()} Rejogar?", "Resultado", MessageBoxButtons.YesNo);

            var gameEndedArgs = new GameEndedEventArgs {
                PlayAgain = result == DialogResult.Yes
            };

            GameEnded?.Invoke(this, gameEndedArgs);
            this.Close();
        }
    }
}
