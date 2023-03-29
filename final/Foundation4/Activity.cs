public class Activity
{
    private DateTime date;
    public int length;

    public Activity(DateTime date, int length)
    {
        this.date = date;
        this.length = length;
    }


    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    // Method to get the summary string for this activity
    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({length} min)";
    }
}

