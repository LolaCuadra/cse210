using System.Threading;
public class Listing : Activities{
    public Listing(){
    activityName = "Listing Activity";
    activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void startActivity()
    {

        Console.WriteLine($"How long, in seconds... ");
        string userInput = Console.ReadLine();
        activityTime = Convert.ToInt32(userInput);

        Console.WriteLine("Get Ready...");

        Thread.Sleep(1000);

        var promts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

         var random = new Random();
         int index = random.Next(promts.Count);
        Console.WriteLine(promts[index]);

        for (int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b  \b");
        }

        List<string> items = new List<string>();
        var start = DateTime.UtcNow;

        while (DateTime.UtcNow < start.AddMilliseconds(10000))
        {
            Console.WriteLine("");
            string input = Console.ReadLine();

            items.Add(input);
        }

        Console.WriteLine("You wrote in total:" + items.Count);

    }
    
}