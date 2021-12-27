using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_cloning_ways
{
    //Method 6 : Constructor
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Team()
        {

        }
        public Team(Team team)
        {
            this.Id = team.Id;
            this.Name = team.Name;
        }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Team Team { get; set; }

        public Player()
        {

        }
        public Player(Player player)
        {
            this.Id = player.Id;
            this.Name = player.Name;
            this.Team = new Team(player.Team);
        }
    }
}
