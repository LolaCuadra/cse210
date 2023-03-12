// Goal tracker app
goalTracker goaltracker = new goalTracker();
// goaltracker.addGoal();

while (true)
{
    Console.WriteLine("Menu Options: ");
    Console.WriteLine("1. Create New Goal. ");
    Console.WriteLine("2. List Goal. ");
    Console.WriteLine("3. Save Goal. ");
    Console.WriteLine("4. Load goals. ");
    Console.WriteLine("5. Record event. ");
    Console.WriteLine("6. Exit. ");
    Console.WriteLine("Select a choice from the menu: ");

    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        goaltracker.addGoal();
    }
    else if (choice == 2)
    {
              
    }
    else if (choice == 3)
    {
         
    }
    else if (choice == 4)
    {
        goaltracker.saveGoal();
    }
    else if (choice == 5)
    {
        

    }
    else if (choice == 6)
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