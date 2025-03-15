using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
       
        List<int> numbers = new List<int>();  
        int userNumber;  

        // Input loop using a do-while loop for clarity  
        do  
        {  
            Console.Write("Enter a number (0 to quit): ");  
            string userResponse = Console.ReadLine();  

            // Validate user input and add non-zero numbers to the list  
            if (int.TryParse(userResponse, out userNumber) && userNumber != 0)  
            {  
                numbers.Add(userNumber);  
            }  
        } while (userNumber != 0);  

        if (numbers.Count == 0)  
        {  
            Console.WriteLine("No numbers were entered. Exiting.");  
            return; // Exit if no numbers were entered  
        }  

        // Calculate and display the sum  
        int sum = CalculateSum(numbers);  
        Console.WriteLine($"The sum is: {sum}");  

        // Calculate and display the average  
        float average = CalculateAverage(sum, numbers.Count);  
        Console.WriteLine($"The average is: {average}");  

        // Find and display the maximum value  
        int max = FindMax(numbers);  
        Console.WriteLine($"The max is: {max}");  

        // Find the smallest positive number closest to zero  
        int? smallestPositive = FindSmallestPositive(numbers);  
        if (smallestPositive.HasValue)  
        {  
            Console.WriteLine($"The smallest positive number (closest to zero) is: {smallestPositive.Value}");  
        }  
        else  
        {  
            Console.WriteLine("No positive numbers were entered.");  
        }  

        // Sort the numbers and display the sorted list  
        numbers.Sort();  
        Console.WriteLine("The sorted list of numbers is: " + string.Join(", ", numbers));  
    }  

    static int CalculateSum(List<int> numbers)  
    {  
        int sum = 0;  
        foreach (int number in numbers)  
        {  
            sum += number;  
        }  
        return sum;  
    }  

    static float CalculateAverage(int sum, int count)  
    {  
        return count > 0 ? (float)sum / count : 0; // Avoid division by zero  
    }  

    static int FindMax(List<int> numbers)  
    {  
        if (numbers.Count == 0) throw new InvalidOperationException("No elements to find the max.");  

        int max = numbers[0];  
        foreach (int number in numbers)  
        {  
            if (number > max)  
            {  
                max = number;  
            }  
        }  
        return max;  
    }  

    static int? FindSmallestPositive(List<int> numbers)  
    {  
        int? smallestPositive = null;  
        foreach (int number in numbers)  
        {  
            if (number > 0 && (smallestPositive == null || number < smallestPositive))  
            {  
                smallestPositive = number;  
            }  
        }  
        return smallestPositive;  
    }  
}  
