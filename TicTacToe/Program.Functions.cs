partial class Program
{
    private char[] _boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public char playerCharacter = ' ';
    public bool gameEnded = false;

    // Additional methods and properties for the Tic Tac Toe game can be added here
    public void DrawBoard()
    {
        // Draw the Tic Tac Toe board
        Console.Clear();
        // Top row
        Console.WriteLine(" -------------------------------");
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" |    {0}    |    {1}    |    {2}    |",
            _boardPositions[0], _boardPositions[1], _boardPositions[2]);
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" -------------------------------");
        // Middle row
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" |    {0}    |    {1}    |    {2}    |",
            _boardPositions[3], _boardPositions[4], _boardPositions[5]);
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" -------------------------------");
        // Bottom row
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" |    {0}    |    {1}    |    {2}    |",
            _boardPositions[6], _boardPositions[7], _boardPositions[8]);
        Console.WriteLine(" |         |         |         |");
        Console.WriteLine(" -------------------------------");
    }

    public void Play(int player, int input)
    {
        if (player == 1)
        {
            playerCharacter = 'X';
        }
        else if (player == 2)
        {
            playerCharacter = 'O';
        }
        switch (input)
        {
            case 1:
                _boardPositions[0] = playerCharacter;
                break;
            case 2:
                _boardPositions[1] = playerCharacter;
                break;
            case 3:
                _boardPositions[2] = playerCharacter;
                break;
            case 4:
                _boardPositions[3] = playerCharacter;
                break;
            case 5:
                _boardPositions[4] = playerCharacter;
                break;
            case 6:
                _boardPositions[5] = playerCharacter;
                break;
            case 7:
                _boardPositions[6] = playerCharacter;
                break;
            case 8:
                _boardPositions[7] = playerCharacter;
                break;
            case 9:
                _boardPositions[8] = playerCharacter;
                break;
            default:
                Console.WriteLine("Invalid input! Please choose a number between 1 and 9.");
                break;
        }
    }
    public void HorizontalWin()
    {
        char[] playerCharacters = { 'X', 'O' };
        foreach (var character in playerCharacters)
        {
            if ((_boardPositions[0] == character && _boardPositions[1] == character && _boardPositions[2] == character) ||
                (_boardPositions[3] == character && _boardPositions[4] == character && _boardPositions[5] == character) ||
                (_boardPositions[6] == character && _boardPositions[7] == character && _boardPositions[8] == character))
            {
                Console.Clear();
                if (character == 'X')
                {
                    Console.WriteLine("Congratulations!!! Player 1 Wins!!\n" +
                        "You have achieved a horizontal win!");
                }
                else
                {
                    Console.WriteLine("Congratulations!!! Player 2 Wins!!\n" +
                        "You have achieved a horizontal win!");
                }
                gameEnded = true;
                Console.WriteLine("Please press \"Shift+R\" any key to reset the board to play again.");
                var key = Console.ReadKey();
                if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.R)
                {
                    ResetBoard();
                }
                else
                {
                    Console.WriteLine("\nInvalid key combination. Exiting the game.");
                    Environment.Exit(0);
                }
                break;
            }
        }
    }
    public void VerticalWin()
    {
        char[] playerCharacters = { 'X', 'O' };
        foreach (var character in playerCharacters)
        {
            if ((_boardPositions[0] == character && _boardPositions[3] == character && _boardPositions[6] == character) ||
                (_boardPositions[1] == character && _boardPositions[4] == character && _boardPositions[7] == character) ||
                (_boardPositions[2] == character && _boardPositions[5] == character && _boardPositions[8] == character))
            {
                Console.Clear();
                if (character == 'X')
                {
                    Console.WriteLine("Congratulations!!! Player 1 Wins!!\n" +
                        "You have achieved a vertical win!");
                }
                else
                {
                    Console.WriteLine("Congratulations!!! Player 2 Wins!!\n" +
                        "You have achieved a vertical win!");
                }
                gameEnded = true;
                Console.WriteLine("Please press \"Shift+R\" any key to reset the board to play again.");
                var key = Console.ReadKey();
                if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.R)
                {
                    ResetBoard();
                }
                else
                {
                    Console.WriteLine("\nInvalid key combination. Exiting the game.");
                    Environment.Exit(0);
                }
                break;
            }
        }
    }
    public void DiagonalWin()
    {
        char[] playerCharacters = { 'X', 'O' };
        foreach (var character in playerCharacters)
        {
            if ((_boardPositions[0] == character && _boardPositions[4] == character && _boardPositions[8] == character) ||
                (_boardPositions[2] == character && _boardPositions[4] == character && _boardPositions[6] == character))
            {
                Console.Clear();
                if (character == 'X')
                {
                    Console.WriteLine("Congratulations!!! Player 1 Wins!!\n" +
                        "You have achieved a diagonal win!");
                }
                else
                {
                    Console.WriteLine("Congratulations!!! Player 2 Wins!!\n" +
                        "You have achieved a diagonal win!");
                }
                gameEnded = true;
                Console.WriteLine("Please press \"Shift+R\" any key to reset the board to play again.");
                var key = Console.ReadKey();
                if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.R)
                {
                    ResetBoard();
                }
                else
                {
                    Console.WriteLine("\nInvalid key combination. Exiting the game.");
                    Environment.Exit(0);
                }
                break;
            }
        }
    }
    public void DrawGame()
    {
        if (_boardPositions[0] != '1' && _boardPositions[1] != '2' &&
            _boardPositions[2] != '3' && _boardPositions[3] != '4' &&
            _boardPositions[4] != '5' && _boardPositions[5] != '6' &&
            _boardPositions[6] != '7' && _boardPositions[7] != '8' &&
            _boardPositions[8] != '9')
        {
            Console.Clear();
            Console.WriteLine("The game is a draw! No more moves possible.");
            gameEnded = true;
            Console.WriteLine("Please press \"Shift+R\" any key to reset the board to play again.");
            var key = Console.ReadKey();
            if (key.Modifiers == ConsoleModifiers.Shift && key.Key == ConsoleKey.R)
            {
                ResetBoard();
            }
            else
            {
                Console.WriteLine("\nInvalid key combination. Exiting the game.");
                Environment.Exit(0);
            }
        }
    }
    public void ResetBoard()
    {
        char[] ArrBoardInitialize = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        _boardPositions = ArrBoardInitialize;
        DrawBoard();
        gameEnded = false;
    }
}
