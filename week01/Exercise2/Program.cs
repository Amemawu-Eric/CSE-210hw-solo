using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        string answer = Console.ReadLine();  
int percent = int.Parse(answer);  

string letter;  
string sign = "";  

// Determine the letter grade  
if (percent >= 90)  
{  
    letter = "A";  
}  
else if (percent >= 80)  
{  
    letter = "B";  
}  
else if (percent >= 70)  
{  
    letter = "C";  
}  
else if (percent >= 60)  
{  
    letter = "D";  
}  
else  
{  
    letter = "F";  
}  

// Check for the sign for grades A, B, C, D  
if (letter != "F")  
{  
    int lastDigit = percent % 10;  

    if (lastDigit >= 7)  
    {  
        sign = "+"; // Plus for last digit 7, 8, or 9  
    }  
    else if (lastDigit < 3)  
    {  
        sign = "-"; // Minus for last digit 0, 1, or 2  
    }  
}  

// Handle special cases for A and F  
if (letter == "A" && sign == "+")  
{  
    sign = ""; // No A+ grade, so clear sign  
}  
else if (letter == "F")  
{  
    sign = ""; // No F+ or F- grade  
}  

// Display both the grade letter and the sign  
Console.WriteLine($"Your grade is: {letter}{sign}");  

if (percent >= 70)  
{  
    Console.WriteLine("You passed!");  
}  
else  
{  
    Console.WriteLine("Better luck next time!");  
}  
    }
}