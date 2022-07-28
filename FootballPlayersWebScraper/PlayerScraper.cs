using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace FootballPlayersWebScraper
{
    public class PlayerScraper
    {
        public static List<Player> GetPlayers(string url)
        {
            List<Player> players = new List<Player>();

            var web = new HtmlWeb();
            var document = web.Load(url);

            Console.WriteLine("url: " + url);

            var nodes = document.DocumentNode.SelectNodes("//*[@id=\"mainContent\"]/div[3]/div/ul");
            foreach (HtmlAgilityPack.HtmlNode node in nodes)
            {
                var li = node.SelectNodes("li");
                foreach (var li2 in li)
                {
                    Player player = new Player();

                    var name = li2.Descendants("h4");
                    foreach (HtmlNode item in name)
                    {
                        player.Name = item.InnerText;
                    }

                    var number = li2.Descendants("span").Where(node => node.GetAttributeValue("class", "").Contains("number"));
                    foreach (HtmlNode item in number)
                    {
                        player.Number = item.InnerText;
                    }
                    var position = li2.Descendants("span").Where(node => node.GetAttributeValue("class", "").Contains("position"));
                    foreach (HtmlNode item in position)
                    {
                        player.Position = item.InnerText;
                    }
                    var nationality = li2.Descendants("span").Where(node => node.GetAttributeValue("class", "").Contains("playerCountry"));
                    foreach (HtmlNode item in nationality)
                    {
                        player.Nationality = item.InnerText;
                    }
                    //getting club name from url
                    var club = url.Substring(36);
                    club = club.Substring(club.IndexOf('/') + 1);
                    club = club.Substring(0, club.IndexOf('/'));
                    club = club.Replace('-', ' ');
                    player.Club = club;

                    players.Add(player);
                }
            }
            return players;

        }

    }
}
