public class goalTracker{
    List<Goal> goals = new List<Goal>();

    public int totalPoints = 0;
    public void addGoal(){

        Console.WriteLine("Press 1 for Simple goal, Press 2 for an Eternal goal, Press 3 for a Checklist goal. ");
        string choice = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string goalName= Console.ReadLine();
        Console.WriteLine("Whats a short description of your goal? ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is that worth? ");
        int pointWorth = int.Parse(Console.ReadLine());

        if(choice == "1"){
            Simple simple = new Simple(goalName, goalDescription, pointWorth, false);
            simple._goalType = "simple";
            goals.Add(simple);
        }
        else if(choice == "2"){
            Eternal eternal = new Eternal(goalName, goalDescription, pointWorth);
            eternal._goalType = "eternal";
            goals.Add(eternal);
        }
        else if(choice == "3"){
            Console.WriteLine("how many times for a bonus?");
            int amount = int.Parse(Console.ReadLine());
            Checklist checklist = new Checklist(goalName, goalDescription, pointWorth, amount, false);
            checklist._goalType = "checklist";
            goals.Add(checklist);
        }

    }

    public void saveGoal(){

        string fileName = "goal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(totalPoints);
            foreach(Goal goal in goals){

                outputFile.WriteLine($"{goal._goalType}:{goal._goalName},{goal._goalDescription},{goal._pointWorth},{goal.isChecked}.");
            }

        }
    }

    public void completeGoal(){
        Console.WriteLine("please chose the goal you completed");
        int choice = int.Parse(Console.ReadLine())-1;
        if (!goals[choice].isChecked) {
            totalPoints += goals[choice]._pointWorth;
            goals[choice].checkGoal();
        }
    }

    public void displayGoal(){
        foreach (Goal goal in goals)
        {
            goal.displayGoal();
        }
    }

    public void readGoal(){
        string filePath = "goal.txt";

        Console.WriteLine("the goals are: ");
        
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}