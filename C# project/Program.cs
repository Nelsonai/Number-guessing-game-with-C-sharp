namespace project
{
    class program{
        static void Main(string[] args)
        {
            getAppInfo(); //Getting app info from function below.

            getPlayerInfo();

            
            while(true){
                // Correct number
                // var Number = 10;

                // Creating a random variable
                Random ran = new Random();

                // The correct random number
                int Number = ran.Next(1, 10);

                Console.WriteLine("Guess a number between 1 and 10.");
                // Initializing the users guess
                int guess = 0;

                // While loop to iterate over the Condition

                while(guess != Number){
                    try
                    {
                        guess =  Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.Exception)
                    {
                        // Color message
                        ColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going with the code 
                        continue;
                    }
                    
                    if(guess!= Number){
                        ColorMessage(ConsoleColor.Red, "You guessed Wrong!");
                    }

                }
                ColorMessage(ConsoleColor.DarkYellow, "You guessed Right!");

                // Ask to play again
                Console.WriteLine("Want to play again [Y or N]: ");
                var answer = Console.ReadLine().ToUpper();

                if(answer == "Y" || answer == "Yes" || answer == "yes" || answer == "YES"){
                    continue;
                }
                else if(answer == "N" || answer == "NO" || answer == "no" || answer == "No"){
                    ColorMessage(ConsoleColor.Green, "Nice playing with you!");
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        // ? App info
        static void getAppInfo(){
            // Setting app details
            var appCreator = "Onyekachi Nelson Oriaku";
            var appVersion = "1.0.0";
            var appName = "Number guesser";

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Application information
            Console.WriteLine($"{appName} version: {appVersion} by {appCreator}");

            // Reseting text color
            Console.ResetColor();
        }

        // ? Getting User info
        static void getPlayerInfo(){
            // User name
            Console.WriteLine("What is your Name? ");

            // Get user input
            var input = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Hello {input}, Let's play a game...");
            Console.ResetColor();
        }

        static void ColorMessage(ConsoleColor color, string message){
            // Changing font Color
            Console.ForegroundColor = color;

            // Incorrect input
            Console.WriteLine(message);

            // Reseting text color
            Console.ResetColor();
        }
    }
}