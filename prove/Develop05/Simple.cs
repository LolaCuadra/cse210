public class Simple : Goal{

    public Simple(string goalName, string goalDescription, int pointWorth, bool isChecked) {
        _pointWorth = pointWorth;
        _goalDescription = goalDescription;
        _goalName = goalName;

        this.isChecked = isChecked;
    }

    public override void listGoal()
    {
        if (isChecked) {
            Console.WriteLine($"[X]{_goalName} ({_goalDescription})");
        }
        else {
            Console.WriteLine($"[ ]{_goalName} ({_goalDescription})");
        }
    }

    public override int checkGoal()
    {
        isChecked = true;
        return _pointWorth;
    }

    public override void displayGoal()
    {
         if (isChecked) {
            Console.WriteLine($"[X]{_goalName} ({_goalDescription})");
        }
        else {
            Console.WriteLine($"[ ]{_goalName} ({_goalDescription})");
        }
    }


}