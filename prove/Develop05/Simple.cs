public class Simple : Goal{

    public Simple(string goalName, string goalDescription, int pointWorth) {
        _pointWorth = pointWorth;
        _goalDescription = goalDescription;
        _goalName = goalName;
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
}