partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic Tac Toe!");
        // Additional game logic would go here
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        Program program = new Program();
        int currentTurn = 1;
        int playerInput = 0;
        bool validInputGiven = true;

        while (!program.gameEnded)
        {
            program.DrawBoard();
            validInputGiven = false;
            while (!validInputGiven)
            {
                Console.WriteLine("\nReady Player {0}: It's your move!", currentTurn);
                try
                {
                    if (currentTurn == 2)
                    {
                        int[] options = program._boardPositions
                            .Where(x => x != 'X' && x != 'O')
                            .Select(x => x - '0')
                            .ToArray();
                        Random random = new Random();
                        int randomIndex = random.Next(options.Length);
                        playerInput = options[randomIndex];
                    }
                    else
                    {
                        playerInput = Convert.ToInt32(Console.ReadLine());
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number.\nGive it another Try...");
                    continue;
                }
                if ((playerInput == 1) && (program._boardPositions[0] == '1'))
                    validInputGiven = true;
                else if ((playerInput == 2) && (program._boardPositions[1] == '2'))
                    validInputGiven = true;
                else if ((playerInput == 3) && (program._boardPositions[2] == '3'))
                    validInputGiven = true;
                else if ((playerInput == 4) && (program._boardPositions[3] == '4'))
                    validInputGiven = true;
                else if ((playerInput == 5) && (program._boardPositions[4] == '5'))
                    validInputGiven = true;
                else if ((playerInput == 6) && (program._boardPositions[5] == '6'))
                    validInputGiven = true;
                else if ((playerInput == 7) && (program._boardPositions[6] == '7'))
                    validInputGiven = true;
                else if ((playerInput == 8) && (program._boardPositions[7] == '8'))
                    validInputGiven = true;
                else if ((playerInput == 9) && (program._boardPositions[8] == '9'))
                    validInputGiven = true;
                else
                {
                    Console.WriteLine("Please choose a valid and available board position. \n" +
                        "Give it another Try...");
                }
                if (currentTurn == 2)
                {
                    program.Play(currentTurn, playerInput);
                    currentTurn = 1;
                }
                else if (currentTurn == 1)
                {
                    program.Play(currentTurn, playerInput);
                    currentTurn = 2;
                }

                program.HorizontalWin();
                program.VerticalWin();
                program.DiagonalWin();
                program.DrawGame();
            }
        }
    }
}




