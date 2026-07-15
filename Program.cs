namespace GameCollectionManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            do
            {
                //Console.Clear();

                ShowMainMenu();

                string option = Console.ReadLine() ?? string.Empty;

                bool success = int.TryParse(option, out int number);
                if (!success) { Console.WriteLine("\nInvalid input. Please enter a number."); }
                else
                {
                    isRunning = ProcessOption(number); ;
                }

            } while (isRunning);
        }


        private static void ShowMainMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("GAME COLLECTION MANAGER");
            Console.WriteLine("=======================");
            Console.WriteLine();
            Console.WriteLine("1. Add Game.");
            Console.WriteLine("2. Show Games Collection");
            Console.WriteLine("3. Search Game");
            Console.WriteLine("0. Exit.\n\n");

        }

        private static bool ProcessOption(int number)
        {
            switch (number)
                    {
                        default:
                            Console.WriteLine("\nOption not available.");
                            return true;

                        case 0:
                            Console.WriteLine("\nExit.");
                            return false;
                        case 1:
                            Console.WriteLine("\nAdd Game Selected.");
                            return true;
                        case 2:
                            Console.WriteLine("\nShow Games Collection.");
                            return true;
                        case 3:
                            Console.WriteLine("\nSearch Game selected.");
                            return true;
            }
        }
    }
}
