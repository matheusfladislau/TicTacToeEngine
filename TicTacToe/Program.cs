public class Program {
    public static void Main(string[] args) {
        Abertura();

        TicTacToeGame tic = new TicTacToeGame();
        string jogarNovamente = "S";

        while (jogarNovamente.Equals("S")) {
            EscolherSimbolo(out string p1, out string p2);
            tic.setPlayer1(p1);
            tic.setPlayer2(p2);
            tic.Start();

            while (!tic.Ended()) {
                Console.Clear();
                PrintarMatriz(tic.matrix);

                Console.WriteLine("Vez do jogador do símbolo {0}!", tic.GetCurrentPlayerSymbol()); 
                EscolherNumeroDisponivel(tic);
                tic.NextRound();
            }
            Console.WriteLine($"Resultado: {tic.Result()}");

            Console.WriteLine($"Quer jogar novamente? (S/N)");
            jogarNovamente = Console.ReadLine()!;
            while (jogarNovamente != "S" && jogarNovamente != "N") {
                Console.WriteLine("Apenas (S/N)!");
                jogarNovamente = Console.ReadLine()!;
            }

            if (jogarNovamente.Equals("S")) {
                tic.Restart();
                Console.Clear();
            }
        }
    }

    private static void Abertura() {
        Console.Clear();
        Console.WriteLine("Jogo da velha!");
    }

    private static void EscolherSimbolo(out string p1, out string p2) {
        Console.WriteLine("Jogador 1: X ou O?");
        p1 = Console.ReadLine()!;

        while (p1 != "X" && p1 != "O") {
            Console.WriteLine("Escreva X ou O");
            p1 = Console.ReadLine()!;
        }
        p2 = (p1.Equals("X")) ? "O" : "X";

        Console.WriteLine("Jogador 1 = {0}, Jogador 2 = {1}", p1, p2);
        Console.WriteLine("Aperte qualquer tecla para iniciar.");
        Console.ReadKey();
    }

    private static void PrintarMatriz(string[,] matrix) {
        for (int i = 0; i < 3; i++) {
            Console.WriteLine("{0}|{1}|{2}", matrix[i, 0], 
                    matrix[i, 1], 
                    matrix[i, 2]);
            if (i < 2) {
                Console.WriteLine("=====");
            }
        }
    }

    private static int LerNumero() {
        int number = -1;
        while (number < 1 || number > 9) {
            while (!Int32.TryParse(Console.ReadLine(), out number) || (number < 1 || number > 9)) {
                Console.WriteLine("Escreva um número entre 1-9!");
            }
        }
        return number;
    }

    private static void EscolherNumeroDisponivel(TicTacToeGame tic) {
        Console.WriteLine("Escolha um número disponível.");

        bool icExiste = tic.SubstituteFieldMatrix(LerNumero());
        while (!icExiste) {
            Console.WriteLine("Escolha um número disponível!");
            icExiste = tic.SubstituteFieldMatrix(LerNumero());
        }
    }
}
