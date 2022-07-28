using FootballPlayersWebScraper;
using System.Collections.Immutable;

List<string> urls = new List<string>
{
    "https://www.premierleague.com/clubs/127/Bournemouth/squad",
    "https://www.premierleague.com/clubs/1/Arsenal/squad",
    "https://www.premierleague.com/clubs/2/Aston-Villa/squad",
    "https://www.premierleague.com/clubs/130/Brentford/squad",
    "https://www.premierleague.com/clubs/131/Brighton-and-Hove-Albion/squad",
    "https://www.premierleague.com/clubs/4/Chelsea/squad",
    "https://www.premierleague.com/clubs/6/Crystal-Palace/squad",
    "https://www.premierleague.com/clubs/7/Everton/squad",
    "https://www.premierleague.com/clubs/34/Fulham/squad",
    "https://www.premierleague.com/clubs/26/Leicester-City/squad",
    "https://www.premierleague.com/clubs/9/Leeds-United/squad",
    "https://www.premierleague.com/clubs/10/Liverpool/squad",
    "https://www.premierleague.com/clubs/11/Manchester-City/squad",
    "https://www.premierleague.com/clubs/12/Manchester-United/squad",
    "https://www.premierleague.com/clubs/23/Newcastle-United/squad",
    "https://www.premierleague.com/clubs/15/Nottingham-Forest/squad",
    "https://www.premierleague.com/clubs/20/Southampton/squad",
    "https://www.premierleague.com/clubs/21/Tottenham-Hotspur/squad",
    "https://www.premierleague.com/clubs/25/West-Ham-United/squad",
    "https://www.premierleague.com/clubs/38/Wolverhampton-Wanderers/squad"
};
var immutableUrls = urls.ToImmutableList();
var allPlayers = new List<Player>();

foreach(var item in immutableUrls)
{
    allPlayers = allPlayers.Concat(PlayerScraper.GetPlayers(item)).ToList();
}

foreach(var player in allPlayers)
{
    Console.WriteLine($"name: {player.Name}");
    Console.WriteLine($"number: {player.Number}");
    Console.WriteLine($"position: {player.Position}");
    Console.WriteLine($"nationality: {player.Nationality}");
    Console.WriteLine($"club: {player.Club}");
    Console.WriteLine();
}
