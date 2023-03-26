using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_Ros_Diana
{
    internal class Team
    {
        private string teamName;
        private string teamCountry;
        private string teamCity;
        private List<Player> teams;

        public string _teamName
        {
            get { return teamName; }
            set { teamName = value; }
        }

        public string _teamCountry
        {
            get { return teamCountry; }
            set { teamCountry = value; }
        }

        public string _teamCity
        {
            get { return teamCity; }
            set { teamCity = value; }
        }

        public List<Player> playerlist
        {
            get { return teams; }
            set { teams = value; }
        }
    }
}
