using System;  
using System.Collections.Generic;  
using System.IO;  

namespace DailyJournal  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            Console.WriteLine("Hello World! This is the Journal Project.");  
            Journal journal = new Journal();  

            while (true)  
            {  
                Console.WriteLine("\nJournal Menu:");  
                Console.WriteLine("1. Write a new entry");  
                Console.WriteLine("2. Display journal");  
                Console.WriteLine("3. Save journal to file");  
                Console.WriteLine("4. Load journal from file");  
                Console.WriteLine("5. Exit");  
                Console.Write("Choose an option (1-5): ");  

                string choice = Console.ReadLine();  
                switch (choice)  
                {  
                    case "1":  
                        journal.AddEntry();  
                        break;  
                    case "2":  
                        journal.DisplayEntries();  
                        break;  
                    case "3":  
                        journal.SaveToFile();  
                        break;  
                    case "4":  
                        journal.LoadFromFile();  
                        break;  
                    case "5":  
                        Console.WriteLine("Exiting the journal. Goodbye!");  
                        return;  
                    default:  
                        Console.WriteLine("Invalid choice. Please try again.");  
                        break;  
                }  
            }  
        }  
    }  

    class Journal  
    {  
        private List<Entry> entries;  

        public Journal()  
        {  
            entries = new List<Entry>();  
        }  

        public void AddEntry()  
        {  
            string prompt = GetRandomPrompt();  
            Console.Write(prompt + " ");  
            string response = Console.ReadLine();  
            string date = DateTime.Now.ToString("MM/dd/yyyy");  
            entries.Add(new Entry(prompt, response, date));  
        }  

        public void DisplayEntries()  
        {  
            if (entries.Count == 0)  
            {  
                Console.WriteLine("No entries found.");  
                return;  
            }  

            foreach (Entry entry in entries)  
            {  
                Console.WriteLine(entry.ToString());  
            }  
        }  

        public void SaveToFile()  
        {  
            Console.Write("Enter Filename: ");  
            string filename = Console.ReadLine();  

            using (StreamWriter writer = new StreamWriter(filename))  
            {  
                writer.WriteLine("Date,Prompt,Response");  

                foreach (Entry entry in entries)  
                {  
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt().Replace(",", ",,")},{entry.GetResponse().Replace(",", ",,")}");  
                }  
            }  

            Console.WriteLine("Saved");  
        }  

        public void LoadFromFile()  
        {  
            Console.Write("Enter filename: ");  
            string filename = Console.ReadLine();  
            entries.Clear();  

            if (!File.Exists(filename))  
            {  
                Console.WriteLine("File not found. Please check the filename and try again.");  
                return;  
            }  

            using (StreamReader reader = new StreamReader(filename))  
            {  
                string headerLine = reader.ReadLine(); // Read and discard the header line  

                while (!reader.EndOfStream)  
                {  
                    string entryLine = reader.ReadLine();  
                    string[] fields = entryLine.Split(',');  

                    string date = fields[0];  
                    string prompt = fields[1].Replace(",,", ",");  
                    string response = fields[2].Replace(",,", ",");  

                    entries.Add(new Entry(prompt, response, date));  
                }  
            }  

            Console.WriteLine("Loaded");  
        }  

        private string GetRandomPrompt()  
        {  
            List<string> prompts = new List<string>  
            {  
                "Who was the most interesting person I interacted with today?",  
                "What was the best part of my day?",  
                "How did I see the hand of the Lord in my life today?",  
                "What was the strongest emotion I felt today?",  
                "If I had one thing I could do over today, what would it be?"  
            };  

            Random random = new Random();  
            return prompts[random.Next(prompts.Count)];  
        }  
    }  

    class Entry  
    {  
        private string prompt;  
        private string response;  
        private string date;  

        public Entry(string prompt, string response, string date)  
        {  
            this.prompt = prompt;  
            this.response = response;  
            this.date = date;  
        }  

        public string GetDate() => date;  
        public string GetPrompt() => prompt;  
        public string GetResponse() => response;  

        public override string ToString()  
        {  
            return $"{date} - {prompt}: {response}";  
        }  
    }  
}  