public sealed class TicTacToeGame { 
    private string? _playerOneSymbol { get; set; }
    private string? _playerTwoSymbol { get; set; }
    private bool _draw { get; set; }
    private bool _playerOneWon { get; set; }
    private bool _currentPlayerOne { get; set; } = true;

    public bool isEnded { get; private set; }
    public string[,] matrix { get; private set; } = new string[3,3];

    public void setPlayer1(string player1) {
        if (!string.IsNullOrEmpty(_playerTwoSymbol) && player1.Equals(_playerTwoSymbol)) {
            throw new ArgumentException("Both players can't use the same character!");
        }

        if (!player1.Equals("X") && !player1.Equals("O")) {
            throw new ArgumentException("Player needs to be either X or O!");
        }
        this._playerOneSymbol = player1;
    }

    public void setPlayer2(string player2) {
        if (!string.IsNullOrEmpty(_playerOneSymbol) && player2.Equals(_playerTwoSymbol)) {
            throw new ArgumentException("Both players can't use the same character!");
        }

        if (!player2.Equals("X") && !player2.Equals("O")) {
            throw new ArgumentException("Player needs to be either X or O!");
        }

        this._playerTwoSymbol = player2;
    }

    public bool Ended() => this.isEnded;

    public string Result() {
        if (!Ended()) {
            return "Still playing.";
        }

        if (this._draw) {
            return "Draw.";
        }

        if (this._playerOneWon) {
            return "Player 1 won.";
        }
        return "Player 2 won.";
    }

    public void Start() {
        PopulateMatrix();
    }

    public void NextRound() {
        if (Won() || Draw()) {
            this.isEnded = true;
            this._playerOneWon = this._currentPlayerOne;
        };
        this._currentPlayerOne = !this._currentPlayerOne;
    }

    public string GetCurrentPlayerSymbol() {
        return _currentPlayerOne ? _playerOneSymbol! : _playerTwoSymbol!;
    }
    
    private bool Won() {
        string? curPlayerChar = GetCurrentPlayerSymbol();

        for (int i = 0; i < 3; i++) {
            if (matrix[i, 0] == curPlayerChar &&
                    matrix[i, 1] == curPlayerChar &&
                    matrix[i, 2] == curPlayerChar) {
                return true;
            }

            if (matrix[0, i] == curPlayerChar &&
                    matrix[1, i] == curPlayerChar &&
                    matrix[2, i] == curPlayerChar) {
                return true;
            }
        }

        if (matrix[0, 0] == curPlayerChar &&
                matrix[1, 1] == curPlayerChar &&
                matrix[2, 2] == curPlayerChar) {
            return true;
        }

        if (matrix[2, 0] == curPlayerChar &&
                matrix[1, 1] == curPlayerChar &&
                matrix[0, 2] == curPlayerChar) {
            return true;
        }

        return false;
    }

    private bool Draw() {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (matrix[i,j] != "X" && matrix[i,j] != "O") {
                    return false;
                }
            }
        }
        this._draw = true;
        return true;
    }

    private void PopulateMatrix() {
        int sum = 0;
        for (int i = 0; i < 3; i++) {
            matrix[i, 0] = (sum + i + 1).ToString();
            matrix[i, 1] = (sum + i + 2).ToString();
            matrix[i, 2] = (sum + i + 3).ToString();
            sum += 2;
        }
    }

    public bool SubstituteFieldMatrix(int number) {
        if (number < 1 || number > 9) {
            throw new ArgumentException("The number should be between 1-9!");
        }

        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                if (matrix[i,j].Equals(number.ToString())) {
                    PutCharInMatrix(i, j);
                    return true;
                }
            }
        }
        return false;
    }

    private void PutCharInMatrix(int i, int j) {
        matrix[i, j] = GetCurrentPlayerSymbol();
    }
    
    public void Restart() {
        this._playerOneSymbol = null;
        this._playerTwoSymbol = null;
        this._draw = false;
        this._playerOneWon = false;
        this._currentPlayerOne = true;
        this.isEnded = false;
    }
}
