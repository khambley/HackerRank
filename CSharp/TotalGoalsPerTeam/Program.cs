using Newtonsoft.Json;

namespace TotalGoalsPerTeam;

class Program
{
    public async static Task Main(string[] args)
    {
        string? team = Console.ReadLine();

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        int result = await Result.getTotalGoalsAsync(team, year);

        Console.WriteLine(result);
    }
}
class Result
{

    /*
     * Complete the 'getTotalGoals' function below.
     *
     * The function is expected to return an INTEGER. Expected Output: 35 
     * The function accepts following parameters:
     *  1. STRING team "Barcelona"
     *  2. INTEGER year "2011"
     */

    public static async Task<int> getTotalGoalsAsync(string team, int year)
    {
        var totalGoals = 0;
        var client = new HttpClient();
        var url = new Uri($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1={team}");
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        var response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead);
        var json = response.Content == null ? null : await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode && json != null)
        {
            var result = JsonConvert.DeserializeObject<Matches>(json);

            if (result != null)
            {
                var matches = result.data;

                int team1goals = 0;

                if (matches != null)
                {
                    foreach (var match in matches)
                    {
                        team1goals += match.team1goals;
                    }

                    totalGoals += team1goals;
                }
            }
        }

        var url2 = new Uri($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team2={team}");
        request = new HttpRequestMessage(HttpMethod.Get, url2);
        response = await client.SendAsync(request, HttpCompletionOption.ResponseContentRead);
        json = response.Content == null ? null : await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode && json != null)
        {
            var result = JsonConvert.DeserializeObject<Matches>(json);

            if (result != null)
            {
                var matches = result.data;

                int team2goals = 0;

                if (matches != null)
                {
                    foreach (var match in matches)
                    {
                        team2goals += match.team2goals;
                    }

                    totalGoals += team2goals;
                }
            }
        }
        return totalGoals;
    }
}
class Matches
{
    public int page { get; set; }
    public int per_page { get; set; }
    public int total { get; set; }
    public int total_pages { get; set; }
    public List<Match>? data { get; set; }
}
class Match
{
    public string? team1 { get; set; }
    public string? team2 { get; set; }
    public int team1goals { get; set; }
    public int team2goals { get; set; }

}

