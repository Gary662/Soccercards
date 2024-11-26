using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Soccercards.Models;

namespace Soccercards
{
    public partial class Form1 : Form
    {
        private List<Player> players;

        public Form1()
        {
            InitializeComponent();
            LoadPlayerData();
            BindPlayerList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Load the player data
        private void LoadPlayerData()
        {
            players = new List<Player>
        {
            new Player { Name = "Bruno Fernandes", Age = 32, Team = "Manchester United", Photo = @"images\Fernandes.jpg", Goals = 12, Assists = 9, Passes = 450, Tackles = 20, YellowCards = 3, RedCards = 1, Appearances = 30 },
            new Player { Name = "Mohamed Salah", Age = 35, Team = "Liverpool", Photo = @"images\Salah.jpg", Goals = 22, Assists = 6, Passes = 370, Tackles = 15, YellowCards = 1, RedCards = 0, Appearances = 28 },
            new Player { Name = "Lionel Messi", Age = 36, Team = "Paris Saint-Germain", Photo = @"images\Messi.jpg", Goals = 28, Assists = 10, Passes = 550, Tackles = 12, YellowCards = 2, RedCards = 0, Appearances = 32 },
            new Player { Name = "Cristiano Ronaldo", Age = 39, Team = "Al Nassr", Photo = @"images\Ronaldo.jpg", Goals = 24, Assists = 5, Passes = 400, Tackles = 10, YellowCards = 4, RedCards = 0, Appearances = 30 },
            new Player { Name = "Kylian Mbappé", Age = 25, Team = "Paris Saint-Germain", Photo = @"images\Mbappe.jpg", Goals = 25, Assists = 15, Passes = 400, Tackles = 50, YellowCards = 20, RedCards = 1, Appearances = 300 },
            new Player { Name = "Kevin De Bruyne", Age = 33, Team = "Manchester City", Photo = @"images\DeBruyne.jpg", Goals = 12, Assists = 20, Passes = 1200, Tackles = 50, YellowCards = 4, RedCards = 1, Appearances = 38 },
            new Player { Name = "Sergio Ramos", Age = 38, Team = "Paris Saint-Germain", Photo = @"images\Ramos.jpg", Goals = 8, Assists = 2, Passes = 300, Tackles = 500, YellowCards = 160, RedCards = 26, Appearances = 700 },
            new Player { Name = "Neymar Jr.", Age = 31, Team = "Al Hilal", Photo = @"images\Neymar.jpg", Goals = 15, Assists = 12, Passes = 600, Tackles = 80, YellowCards = 5, RedCards = 1, Appearances = 25 },
            new Player { Name = "Virgil van Dijk", Age = 33, Team = "Liverpool", Photo = @"images\vvd.jpg", Goals = 3, Assists = 1, Passes = 500, Tackles = 400, YellowCards = 2, RedCards = 0, Appearances = 29 },
            new Player { Name = "Erling Haaland", Age = 24, Team = "Manchester City", Photo = @"images\Haaland.jpg", Goals = 36, Assists = 10, Passes = 200, Tackles = 12, YellowCards = 1, RedCards = 0, Appearances = 33 }
        };
        }

        // Bind the player list to the ListBox
        private void BindPlayerList()
        {
            lbPlayers.DataSource = null;
            lbPlayers.DataSource = players;
            lbPlayers.DisplayMember = "Name"; // Display names in the list
        }

        // Event when a player is selected from the ListBox
        private void LbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPlayers.SelectedItem != null)
            {
                Player selectedPlayer = (Player)lbPlayers.SelectedItem;

                // Display player image
                pbPlayerPhoto.Image = selectedPlayer.PlayerImage;

                // Display player stats
                lblPlayerName.Text = selectedPlayer.Name;
                lblTeam.Text = $"Team: {selectedPlayer.Team}";
                lblGoals.Text = $"Goals: {selectedPlayer.Goals}";
                lblAssists.Text = $"Assists: {selectedPlayer.Assists}";
                lblPasses.Text = $"Passes: {selectedPlayer.Passes}";
                lblTackles.Text = $"Tackles: {selectedPlayer.Tackles}";
                lblYellowCards.Text = $"Yellow Cards: {selectedPlayer.YellowCards}";
                lblRedCards.Text = $"Red Cards: {selectedPlayer.RedCards}";

                // Change border color based on the team
                if (selectedPlayer.Team == "Manchester United")
                    panelCard.BackColor = Color.Red;
                else if (selectedPlayer.Team == "Liverpool")
                    panelCard.BackColor = Color.DarkRed;
                else if (selectedPlayer.Team == "Paris Saint-Germain")
                    panelCard.BackColor = Color.Gold;
                else if (selectedPlayer.Team == "Manchester City")
                    panelCard.BackColor = Color.LightBlue;
                else if (selectedPlayer.Team == "Al Nassr")
                    panelCard.BackColor = Color.Yellow;
                else if (selectedPlayer.Team == "Al Hilal")
                    panelCard.BackColor = Color.DeepSkyBlue;
                else
                    panelCard.BackColor = Color.Gray;

                // Highlight stats (green for high, red for low)
                lblGoals.ForeColor = selectedPlayer.Goals > 20 ? Color.Green : Color.Red;
                lblAssists.ForeColor = selectedPlayer.Assists > 10 ? Color.Green : Color.Red;
                lblPasses.ForeColor = selectedPlayer.Passes > 400 ? Color.Green : Color.Red;
            }
        }
    }
}
