namespace WinFormsGame {
    public partial class Inicio : Form {
        private readonly TicTacToeEngine _engine;
        public Inicio() {
            this._engine = new TicTacToeEngine();
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e) {
            StartGame("X", "O");
        }

        private void btnO_Click(object sender, EventArgs e) {
            StartGame("O", "X");
        }

        private void StartGame(string playerOneSymbol, string playerTwoSymbol) {
            _engine.SetPlayerOne(playerOneSymbol);
            _engine.SetPlayerTwo(playerTwoSymbol);
            MostrarMensagemSimbolos(playerOneSymbol, playerTwoSymbol);

            this.Hide();

            var jogo = new Jogo(_engine);
            jogo.GameEnded += OnGameEnded;
            jogo.Show();
        }

        private void OnGameEnded(object sender, GameEndedEventArgs e) {
            if (e.PlayAgain) {
                _engine.Restart();
                this.Show();
            } else {
                this.Close();
            }
        }

        private void MostrarMensagemSimbolos(string playerOneSimbolo, string playerTwoSimbolo) {
            MessageBox.Show($"Jogador 1: {playerOneSimbolo} | Jogador 2: {playerTwoSimbolo}", "Símbolos");
        }
    }
}
