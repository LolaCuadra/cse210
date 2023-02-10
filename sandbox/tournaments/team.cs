public class Teams
{
    private string _name;
    private List<Player> _roster =  new List<Player>;

    public Teams(string name)
    {
        _name = name;
    }
    public void addPlayer(Player p)
    {
        _roster.Add(p);
    }
    public void displayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine("----------------------");
        foreach(Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();
    }
    public void AddWin(){
    _wins += 1;
    }

    public void AddLoss(){
        _loss += 1;
    }
}

