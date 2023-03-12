public class Checklist : Goal{
    private int _timesCompleted;
    private int _requiredTimesCompleted;
    private int _bonusValue;


    public Checklist(string goalName, string goalDescription, int pointWorth) {
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
