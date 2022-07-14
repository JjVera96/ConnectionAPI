using ConnectionAPI.Handlers;

var client = new HttpClient();
Console.WriteLine("Connecting to APIs");

string url = "https://api.kanye.rest/";
string response = await client.GetStringAsync(url);
var KanyeJson = Kanye.ToJson(response);
ArgumentNullException.ThrowIfNull(KanyeJson);
string KanyeString = Kanye.ToString(KanyeJson);
Console.WriteLine();
Console.WriteLine(KanyeJson.Quote);
Console.WriteLine(KanyeString);

url = "https://www.balldontlie.io/api/v1/teams/2";
response = await client.GetStringAsync(url);
var NBATeamJson= NBATeam.ToJson(response);
ArgumentNullException.ThrowIfNull(NBATeamJson);
string NBATeaString = NBATeam.ToString(NBATeamJson);
Console.WriteLine();
Console.WriteLine(NBATeamJson.Name);
Console.WriteLine(NBATeaString);

url = "https://www.balldontlie.io/api/v1/players/2";
response = await client.GetStringAsync(url);
var NBAPlayerJson = NBAPlayer.ToJson(response);
ArgumentNullException.ThrowIfNull(NBAPlayerJson);
string NBAPlayerString = NBAPlayer.ToString(NBAPlayerJson);
Console.WriteLine();
Console.WriteLine($"{NBAPlayerJson.FirstName} {NBAPlayerJson.LastName} - {NBAPlayerJson.Team.Name}");
Console.WriteLine(NBAPlayerString);

// https://pokeapi.co/api/v2/pokemon/25;