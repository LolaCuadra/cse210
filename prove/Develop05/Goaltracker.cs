public class goalTracker{
    List<Goal> Goals = new List<Goal>();

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
            Simple simple = new Simple(goalName, goalDescription, pointWorth);
            simple._goalType = "simple";
            Goals.Add(simple);
        }
        else if(choice == "2"){
            Eternal eternal = new Eternal(goalName, goalDescription, pointWorth);
            eternal._goalType = "eternal";
            Goals.Add(eternal);
        }
        else if(choice == "3"){
            Checklist checklist = new Checklist(goalName, goalDescription, pointWorth);
            checklist._goalType = "checklist";
            Goals.Add(checklist);
        }

    }

    public void saveGoal(){

        string fileName = "goal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(totalPoints);
            foreach(Goal goal in Goals){

                outputFile.WriteLine($"{goal._goalType}:{goal._goalName},{goal._goalDescription},{goal._pointWorth},{goal.isChecked}.");
            }

        }
    }

    public void completeGoal(){
        Console.WriteLine("please chose the goal you completed");
        int choice = int.Parse(Console.ReadLine());
        if (!Goals[choice].isChecked) {
            totalPoints += Goals[choice]._pointWorth;
            Goals[choice].checkGoal();
        }
    }
}