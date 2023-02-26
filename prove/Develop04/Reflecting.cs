public class Reflecting : Activities{
     public Reflecting(){
    activityName = "Reflecting Activity";
    activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

     public override void startActivity(){
        Console.WriteLine($"How long, in seconds, would you like to work? ");
        string userInput = Console.ReadLine();
        activityTime = Convert.ToInt32(userInput);

        Console.WriteLine("Get Ready...");

        Thread.Sleep(1000);

        var random = new Random();
        var list = new List<string>{"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

        int index = random.Next(list.Count);
        Console.WriteLine(list[index]);

        for (int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b  \b");
        }

        List<string> questions = new List<string>() {"Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?" };

        int question = random.Next(questions.Count);

        for (int i = 0; i < (activityTime / 6) + 1; i++){

            Console.WriteLine(questions[i]);
            Thread.Sleep(5000);
        }
        
    }
}