using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        


        do  
        {  
            // Step 1: Ask the user for the magic number  
            Console.Write("Please enter a magic number between 1 and 100: ");  
            int magicNumber = int.Parse(Console.ReadLine());  

            // Initialize guess counter  
            int guessCount = 0;  

            // Step 2: Loop until the user guesses the magic number  
            while (true)  
            {  
                Console.Write("Make a guess: ");  
                int guess = int.Parse(Console.ReadLine());  
                guessCount++;  

                // Step 3: Check the guess  
                if (guess < magicNumber)  
                {  
                    Console.WriteLine("Higher! Try again.");  
                }  
                else if (guess > magicNumber)  
                {  
                    Console.WriteLine("Lower! Try again.");  
                }  
                else  
                {  
                    Console.WriteLine($"Congratulations! You've guessed the magic number {magicNumber} in {guessCount} guesses.");  
                    break; // Exit the loop  
                }  
            }  

            // Transition to random number generation  
            PlayRandomGuessingGame();  

            // Ask if the user wants to play again  
            Console.Write("Do you want to play again? (yes/no): ");  
        } while (Console.ReadLine().Trim().ToLower() == "yes");  
       
        Console.WriteLine("Thank you for playing! Goodbye.");  
    }  

    static void PlayRandomGuessingGame()  
    {  
        Random random = new Random();  
        int magicNumber = random.Next(1, 101); // Generate a random number between 1 and 100  
        int guessCount = 0;  

        Console.WriteLine("Now let's play with a random number!");  

        while (true)  
        {  
            Console.Write("Make a guess (between 1 and 100): ");  
            int guess = int.Parse(Console.ReadLine());  
            guessCount++;  

            if (guess < magicNumber)  
            {  
                Console.WriteLine("Higher! Try again.");  
            }  
            else if (guess > magicNumber)  
            {  
                Console.WriteLine("Lower! Try again.");  
            }  
            else  
            {  
                Console.WriteLine($"Congratulations! You've guessed the magic number {magicNumber} in {guessCount} guesses.");  
                break; // Exit the loop  
            }  
        }  
    }  
}  
    