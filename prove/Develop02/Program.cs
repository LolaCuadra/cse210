using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response, DateTime.Now));
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }

    public void SaveJournal(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine(entry.Date);
                writer.WriteLine();
            }
        }
    }

    public void LoadJournal(string fileName)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string prompt = reader.ReadLine();
                string response = reader.ReadLine();
                DateTime date = DateTime.Parse(reader.ReadLine());
                entries.Add(new Entry(prompt, response, date));
                reader.ReadLine();
            }
        }
    }

    class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public Entry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }
    }

    static void Main(string[] args)
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What did I learn today?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What am I grateful for today?"
        };

        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.WriteLine("What would you like to do ?");


            int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
        {
            // Write a new entry
            Random rand = new Random();
            int index = rand.Next(prompts.Count);
            string prompt = prompts[index];

            Console.Write("Please enter your response to the prompt: ");
            string response = Console.ReadLine();

            Entry newEntry = new Entry(prompt, response, DateTime.Now);
            journal.entries.Add(newEntry);
            Console.WriteLine("Entry added successfully!");
        }
        else if (choice == 2)
        {
            // Display the journal
            if (journal.entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
            }
            else
            {
                Console.WriteLine("Journal Entries:");
                foreach (Entry entry in journal.entries)
                {
                    Console.WriteLine(entry);
                }
            }
        }
        else if (choice == 3)
        {
            // Save the journal to a file
            Console.Write("Please enter a filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in journal.entries)
                {
                    writer.WriteLine(entry);
                }
            }
            Console.WriteLine("Journal saved successfully!");
        }
        else if (choice == 4)
        {
            // Load the journal from a file
            Console.Write("Please enter a filename: ");
            string filename = Console.ReadLine();

            journal.entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(",");
                    Entry entry = new Entry(parts[0], parts[1], DateTime.Parse(parts[2]));
                    journal.entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        else if (choice == 5)
        {
            // Exit
            Console.WriteLine("Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }
    }
}
}
            