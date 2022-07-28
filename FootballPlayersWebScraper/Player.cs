using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayersWebScraper
{
    public class Player
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string Club { get; set; }
        public string Number { get; set; } //Player may not have asigned number by club during transfer windows
        public string Position { get; set; } 

    }
}
