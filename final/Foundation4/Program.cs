while (true)
{
    
    Console.WriteLine("What did you do today? ");
    Console.WriteLine("1. Running ");
    Console.WriteLine("2. Cycling ");
    Console.WriteLine("3. Swimming ");
    Console.WriteLine("4. Exit ");

    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {   
       
    }
    else if (choice == 2)
    {
        
    }
    else if (choice == 3)
    {
        
    }
    else if (choice == 4)
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