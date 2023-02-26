// Breathing breathing = new Breathing();
// breathing.intro();
// breathing.startActivity();
// breathing.ending();

// Reflecting reflecting = new Reflecting();
// reflecting.intro();
// reflecting.startActivity();
// reflecting.ending();

// Listing listing = new Listing();
// listing.intro();
// listing.startActivity();
// listing.ending();

 while (true)
{
    Console.WriteLine("Menu Options: ");
    Console.WriteLine("1. Start breathing activity. ");
    Console.WriteLine("2. Start reflecting activity. ");
    Console.WriteLine("3. Start listing activity. ");
    Console.WriteLine("4. Exit");
    Console.WriteLine("Select a choice from the menu: ");

    int choice = int.Parse(Console.ReadLine());
    if (choice == 1)
    {
        Breathing breathing = new Breathing();
        breathing.intro();
        breathing.startActivity();
        breathing.ending();
    }
    else if (choice == 2)
    {
    Reflecting reflecting = new Reflecting();
    reflecting.intro();
    reflecting.startActivity();
    reflecting.ending();           
    }
    else if (choice == 3)
    {
    Listing listing = new Listing();
    listing.intro();
    listing.startActivity();
    listing.ending();           
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