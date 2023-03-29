public class Checklist : Goal{
    public int amount;

    public int amountCompleted = 0;


    public Checklist(string goalName, string goalDescription, int pointWorth, int amount, bool isChecked) {
        _pointWorth = pointWorth;
        _goalDescription = goalDescription;
        _goalName = goalName;
        this.isChecked = isChecked;
        this.amount = amount;
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
        if (amountCompleted == amount)
        {
        isChecked = true;
        return _pointWorth;
        }
        else{
            amountCompleted +=1; 
            return 0;
        }
    }

    public override void displayGoal()
    {
        if (isChecked) {
            Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- {amountCompleted} / {amount}");
        }
        else {
            Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- {amountCompleted} / {amount}");
        }
    }


}
