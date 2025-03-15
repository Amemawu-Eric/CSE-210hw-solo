using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        
        // Display a welcome message  
        DisplayWelcome();  

        // Prompt for the user's name  
        string userName = PromptUserName();  

        // Prompt for the user's favorite number  
        int favoriteNumber = PromptUserNumber();  

        // Square the favorite number  
        int squaredNumber = SquareNumber(favoriteNumber);  

        // Display the result  
        DisplayResult(userName, squaredNumber);  
    }  

    static void DisplayWelcome()  
    {  
        Console.WriteLine("Welcome to the Program!");  
    }  

    static string PromptUserName()  
    {  
        Console.Write("Please enter your name: ");  
        return Console.ReadLine();  
    }  

    static int PromptUserNumber()  
    {  
        Console.Write("Please enter your favorite number: ");  
        int number;  
        while (!int.TryParse(Console.ReadLine(), out number))  
        {  
            Console.Write("Invalid input. Please enter a valid integer: ");  
        }  
        return number;  
    }  

    static int SquareNumber(int number)  
    {  
        return number * number;  
    }  

    static void DisplayResult(string name, int squaredNumber)  
    {  
        Console.WriteLine($"Hello, {name}! The square of your favorite number is: {squaredNumber}");  
    }  
}