public class Breathing : Activities{

    public Breathing(){
    activityName = "Breathing Activity";
    activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    
    }

    public override void startActivity(){
        Console.WriteLine($"How long, in seconds, would you like for your activity? ");
        string userInput = Console.ReadLine();
        activityTime = Convert.ToInt32(userInput);

        Console.WriteLine("Get Ready...");

        Thread.Sleep(1000);

        for (int i = 0; i < (activityTime / 6) + 1; i++){
            Console.WriteLine("Breathe in");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out");
            Thread.Sleep(3000);
        }
    }
}