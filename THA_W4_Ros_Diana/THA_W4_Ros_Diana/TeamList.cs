using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;


namespace THA_W4_Ros_Diana
{
    internal class TeamList
    {
        
        public Team TeamReal()
        {
            string[] playername = { "Thibaut Courtois", "Dani Carvajal", "Éder Militão",
            "David Alaba", "Jesús Vallejo", "Nacho", "Eden Hazard", "Toni Kroos", "Karim Benzema", "Luka Modrić", "Marco Asensio"};
            string[] playernumber = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"};
            string[] playerposisi = { "GK", "DF", "DF", "DF", "DF", "DF", "DF", "FW", "MF", "FW", "MF", "FW", "MF" };
            Team teamlist = new Team();
            teamlist._teamName = "Real Madrid Club";
            teamlist._teamCountry = "Spanyol";
            teamlist._teamCity = "Madrid";
            teamlist.playerlist = new List<Player>();
            for(int i =0; i < playername.Count(); i++)
            {
                Player player1 = new Player();
                player1._playerName = playername[i];
                player1._playerNum = playernumber[i];
                player1._playerPos = playerposisi[i];
                teamlist.playerlist.Add(player1);
                teamlist.playerlist.OrderBy(o => o._playerNum).ToList();
            }
            return teamlist;
        }

        public Team ACMilan()
        {
            string[] playername = { "Ciprian Tătărușanu", "Davide Calabria", "Ismaël Bennacer",
            "Fodé Ballo-Touré", "Yacine Adli", "Nacho", "Sandro Tonali", " Olivier Giroud", "Brahim Díaz", "Zlatan Ibrahimović", "Ante Rebić",
            "Tiémoué Bakayoko"," Mike Maignan","Rafael Leão","Theo Hernandez","Pierre Kalulu"};
            string[] playernumber = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11","12","14","16","17","19","20" };
            string[] playerposisi = { "GK", "DF", "MF", "DF", "MF", "MF", "FW", "MF", "FW", "FW", "MF", "GK", "FW","DF","DF","GK","DF" };
            Team teamlist = new Team();
            teamlist._teamName = "AC Milan";
            teamlist._teamCountry = "Italia";
            teamlist._teamCity = "Milan";
            teamlist.playerlist = new List<Player>();
            for (int i = 0; i < playername.Count(); i++)
            {
                Player player1 = new Player();
                player1._playerName = playername[i];
                player1._playerNum = playernumber[i];
                player1._playerPos = playerposisi[i];
                teamlist.playerlist.Add(player1);
                teamlist.playerlist.OrderBy(o => o._playerNum).ToList();
            }
            return teamlist;
        }

        public Team FCBayernMünchen()
        {
            string[] playername = { "Manuel Neuer", " Dayot Upamecano", "Matthijs de Ligt",
            "Benjamin Pavard", " Joshua Kimmich", " Serge Gnabry", " Leon Goretzka", "Leroy Sané", " Kingsley Coman", "Eric M. Choupo-Moting", "Paul Wanner",
            "Sadio Mané","Alphonso Davies"};
            string[] playernumber = { "01", "02", "04", "05", "07", "08", "10", "11", "13", "14", "17", "19","20"};
            string[] playerposisi = { "GK", "DF", "DF", "DF", "FW", "MF", "FW", "FW", "FW", "MF", "FW", "DF","GK"};
            Team teamlist = new Team();
            teamlist._teamName = "FC Bayern München";
            teamlist._teamCountry = "Jerman";
            teamlist._teamCity = "Bavaria";
            teamlist.playerlist = new List<Player>();
            for (int i = 0; i < playername.Count(); i++)
            {
                Player player1 = new Player();
                player1._playerName = playername[i];
                player1._playerNum = playernumber[i];
                player1._playerPos = playerposisi[i];
                teamlist.playerlist.Add(player1);
                teamlist.playerlist.OrderBy(o => o._playerNum).ToList();
            }
            return teamlist;
        }

    }
}
