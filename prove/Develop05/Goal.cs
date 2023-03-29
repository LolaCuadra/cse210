public abstract class Goal{

    public bool isChecked = false;
    public int _pointWorth;
    public string _goalName;
    public string _goalDescription;
    public string _goalType;

    public Goal() {

    }

    public virtual void listGoal() {

    }

    public abstract int checkGoal();

    public virtual void displayGoal(){
       
    }
}
