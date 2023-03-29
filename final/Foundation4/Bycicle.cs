public class Bycicle : Activity
{
    private double speed;

    public Bycicle(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return speed * (length / 60.0);
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {GetDistance():F1} km, Speed: {speed:F1} kph, Pace: {GetPace():F1} min per km";
    }
}
