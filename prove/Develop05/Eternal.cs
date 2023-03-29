public class Eternal : Goal{
        public Eternal(string goalName, string goalDescription, int pointWorth) {
        _pointWorth = pointWorth;
        _goalDescription = goalDescription;
        _goalName = goalName;
    }

    public override void listGoal()
    {
        Console.WriteLine($"[ ]{_goalName} ({_goalDescription})");
        
    }

// overwriting different instaces 
    public override int checkGoal()
    {
        return _pointWorth;
    }

    public override void displayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
        
    }
}

