namespace TeamInterface;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
class Team
{
    public string? teamName { get; set; }
    public int noOfPlayers { get; set; }

    public Team(string name, int number)
    {
        teamName = name;
        noOfPlayers = number;
    }

    public void AddPlayer(int count)
    {
        noOfPlayers += count;
    }

    public bool RemovePlayer(int count)
    {
        var n = noOfPlayers -= count;

        if(n > 0)
        {
            noOfPlayers -= count;
            return true;
        }
        else
        {
            return false;
        }
    }
}
class SubTeam : Team
{
    public SubTeam(string team_Name, int no_OfPlayers)
        : base(team_Name, no_OfPlayers)
    {
        teamName = team_Name;
        noOfPlayers = no_OfPlayers;
    }

    public void ChangeTeamName(string name)
    {
        teamName = name;
    }
}

