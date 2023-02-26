public class Activities{
    public string activityName;
    public string activityDescription;
    public int activityTime; 

    public void intro(){
        Console.WriteLine($"Welcome to the {activityName}.");
        Console.WriteLine(activityDescription);
    }

    public virtual void startActivity(){

    }

    public void ending(){
    Console.WriteLine($"Well done! You have completed {activityTime} of {activityName}.");

    }
    

}