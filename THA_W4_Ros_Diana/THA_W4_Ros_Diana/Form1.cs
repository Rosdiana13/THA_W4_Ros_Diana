using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_Ros_Diana
{
    public partial class Form1 : Form
    {

        List<Team> teams = new List<Team>();
        public string _player = "";
        public Form1()
        {

            InitializeComponent();
            TeamList _teamlist = new TeamList();
            teams.Add(_teamlist.TeamReal());
            teams.Add(_teamlist.ACMilan());
            teams.Add(_teamlist.FCBayernMünchen());
            Comboboxupdate();
            

        }

        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            bool add = false;
            if (string.IsNullOrEmpty(textBoxTeamCountry.Text) == true && string.IsNullOrEmpty(textBoxTeamCity.Text) == true
                && string.IsNullOrEmpty(textBoxTeamName.Text)== true )
            {
                string mess = "All Fiels Need to be Filled";
                MessageBox.Show(mess, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add= true;
            }
           
            if (add == false)
            {
                comboBox_Choose_Team.Items.Clear();
                Team _teams = new Team();
                _teams._teamCountry = textBoxTeamCountry.Text;
                _teams._teamName = textBoxTeamName.Text;
                _teams._teamCity = textBoxTeamCity.Text;
                _teams.playerlist = new List<Player>();
                teams.Add(_teams);
                Comboboxupdate();
                textBoxTeamCountry.Text = "";
                textBoxTeamName.Text = "";
                textBoxTeamCity.Text = "";
            }
        }

        private void Comboboxupdate()
        {
            comboBox_Choose_Country.Items.Clear();
            foreach (Team team in teams)
            {
                if (!comboBox_Choose_Country.Items.Contains(team._teamCountry))
                {
                    comboBox_Choose_Country.Items.Add(team._teamCountry);
                }
            }
        }

        private void Comboboxupdateteam()
        {
            comboBox_Choose_Team.Items.Clear();
            foreach (Team teamss in teams)
            {
                if (teamss._teamCountry == comboBox_Choose_Country.SelectedItem.ToString())
                {
                    comboBox_Choose_Team.Items.Add(teamss._teamName);
                    
                }
            }
        }
        public void RosterUpdate()
        {
            ListBoxSoccerTeamList.Items.Clear();
            foreach (Team team in teams)
            {
                if (team._teamName == comboBox_Choose_Team.SelectedItem.ToString())
                {
                    foreach (Player player in team.playerlist)
                    {
                      ListBoxSoccerTeamList.Items.Add($"({player._playerNum}) {player._playerName} {player._playerPos}");
                    }
                }
            }
            ListBoxSoccerTeamList.Sorted = true;
        }

        private void comboBox_Choose_Country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ListBoxSoccerTeamList.Items.Clear();

            Comboboxupdateteam();
        }
        private void comboBox_Choose_Team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RosterUpdate();
        }

        private void buttonPlayers_Click(object sender, EventArgs e)
        {
            if (textBoxPlayerName.Text !="" && textBoxPlayerNumber.Text !="" && comboBoxPlayerPostion.SelectedIndex != -1)
            {
                bool addPlayer = false;
                bool numberplayer = false;
                foreach (Team Teampllayer in teams)
                {
                    for (int i = 0; i < Teampllayer.playerlist.Count; i++)
                    {
                        if (Teampllayer.playerlist[i]._playerName == textBoxPlayerName.Text)
                        {
                            addPlayer = true;
    
                        }
                    }
                    for (int i = 0; i < Teampllayer.playerlist.Count; i++)
                    {
                        if (Teampllayer.playerlist[i]._playerNum == textBoxPlayerNumber.Text)
                        {
                            numberplayer = true;
                        }
                        
                    }

                    if (Teampllayer._teamName == comboBox_Choose_Team.SelectedItem.ToString() && addPlayer == false)
                    {
                        Player player = new Player();
                        player._playerName = textBoxPlayerName.Text;
                        player._playerNum = textBoxPlayerNumber.Text;
                        player._playerPos = this.comboBoxPlayerPostion.GetItemText(this.comboBoxPlayerPostion.SelectedItem);
                        Teampllayer.playerlist.Add(player);
                        Teampllayer.playerlist.OrderBy(o => o._playerNum).ToList();
                        RosterUpdate();
                        textBoxPlayerName.Text ="";
                        textBoxPlayerNumber.Text ="";
                        comboBoxPlayerPostion.SelectedIndex = -1;
                        textBoxPlayerName.Focus();
                        
                    }
                }
            }
            else
            {
                string text = "All Fiels Need to be Filled";
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            
            foreach(Team team in teams)
            {
                if (team._teamName == comboBox_Choose_Team.SelectedItem.ToString())
                {
                    if (team.playerlist.Count <= 11)
                    {
                        string mess = "Unable to Remove Plyers if plyers less than equal 11";
                        MessageBox.Show(mess, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    for (int i = 0; i < team.playerlist.Count; i++)
                    {
                        if ($"({team.playerlist[i]._playerNum}) {team.playerlist[i]._playerName} {team.playerlist[i]._playerPos}" == _player)
                        {
                            team.playerlist.RemoveAt(i);
                            i--;
                            RosterUpdate();
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void ListBoxSoccerTeamList_SelectedValueChanged(object sender, EventArgs e)
        {
            _player = ListBoxSoccerTeamList.SelectedItem.ToString();
        }

        private void ListBoxSoccerTeamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
