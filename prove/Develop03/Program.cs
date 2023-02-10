Scripture scripture = new Scripture();

scripture.displayScripture();

while(true){
    Console.WriteLine("Please press either enter to continue or type quit to escape");
    // scripture.displayScripture();
    string userInput = Console.ReadLine();

    if (!(userInput == "quit"))
    {   
        scripture.hideWord();
        scripture.displayScripture();
    }
    else
    {
        break;
    }
}