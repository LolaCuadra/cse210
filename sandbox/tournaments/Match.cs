public class Match{
    private Team _team1;
    private Team _team2;

    public Match(Team team1, Team team2)
    {
        _team1 = team1;
        _team2 = team2;

    } 

    public void DecideWin()
    {
        Console.WriteLine("Which team won?");
        
    }

}