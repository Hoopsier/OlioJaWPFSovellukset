/*
 * Renan Horuz + assistance of gpt-4o due to time crunch of json not working
 */
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace KT25
{
    public partial class MainWindow : Window
    {
        //variables
        private ObservableCollection<Joukkue> observableTeams = new ObservableCollection<Joukkue>();
        private ObservableCollection<Pelaaja> observablePlayers = new ObservableCollection<Pelaaja>();
        private Joukkue selectedJoukkue;
        private string tiedostoPolku = "joukkueet.txt";

        public MainWindow() //call methods and connect data
        {
            InitializeComponent();

            // Initialize DataGrids' ItemsSource
            jDG.ItemsSource = observableTeams;
            pDG.ItemsSource = observablePlayers;

            // Add initial teams
            AddInitialTeams();

            // Select the first team by default, if any
            if (observableTeams.Any())
            {
                jDG.SelectedItem = observableTeams.First();
                selectedJoukkue = observableTeams.First();
                UpdateObservablePlayers();
            }
        }

        private void AddInitialTeams() // can't test without something to test with
        {
            var team1 = new Joukkue("Team A", "City A");
            var team2 = new Joukkue("Team B", "City B");
            var team3 = new Joukkue("Team C", "City C");

            observableTeams.Add(team1);
            observableTeams.Add(team2);
            observableTeams.Add(team3);

            team1.LisääPelaaja(new Pelaaja("John", "Doe", 10, "Team A"));
            team2.LisääPelaaja(new Pelaaja("Jane", "Smith", 11, "Team B"));
            team3.LisääPelaaja(new Pelaaja("Jim", "Brown", 12, "Team C"));
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e) // calls the main method of saving to a file. (For future additions)
        {
            TallennaJoukkueetTiedostoon();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e) // loads data and updates grids
        {
            LataaJoukkueetTiedostosta();
            if (observableTeams.Any())
            {
                jDG.SelectedItem = observableTeams.First();
                selectedJoukkue = observableTeams.First();
                UpdateObservablePlayers();
            }
        }

        private void TallennaJoukkueetTiedostoon() // main save method
        {
            string json = JsonConvert.SerializeObject(observableTeams.ToList(), Formatting.Indented);
            File.WriteAllText(tiedostoPolku, json);
        }

        private void LataaJoukkueetTiedostosta() // method to get data from a file
        {
            if (File.Exists(tiedostoPolku))
            {
                string json = File.ReadAllText(tiedostoPolku);
                var teams = JsonConvert.DeserializeObject<List<Joukkue>>(json);
                observableTeams.Clear();
                foreach (var team in teams)
                {
                    observableTeams.Add(team);
                }
            }
        }

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e) // adds a player to the selected team. (remember to write the correct team, but it works without.)
        {
            if (selectedJoukkue == null)
            {
                MessageBox.Show("Please select a team first.");
                return;
            }

            // Retrieve player information from text boxes
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            int playerNumber;
            string pjoukkue = PlayerTeamTB.Text;

            // Validate and parse player number
            if (!int.TryParse(PlayerNumberTextBox.Text, out playerNumber))
            {
                MessageBox.Show("Invalid player number. Please enter a valid integer.");
                return;
            }

            // Check if player number already exists in the team
            if (selectedJoukkue.HaePelaaja(playerNumber) != null)
            {
                MessageBox.Show($"A player with number {playerNumber} already exists in the team.");
                return;
            }

            // Create a new player object
            Pelaaja newPlayer = new Pelaaja(firstName, lastName, playerNumber, pjoukkue);

            // Add the new player to the team
            selectedJoukkue.LisääPelaaja(newPlayer);

            // Update the observable collection
            observablePlayers.Add(newPlayer);

            // Save the team to file after adding a player
            TallennaJoukkueetTiedostoon();
        }

        private void jDG_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) // team's data grid updates
        {
            selectedJoukkue = jDG.SelectedItem as Joukkue;
            UpdateObservablePlayers();
        }

        private void UpdateObservablePlayers() // get the team's players
        {
            if (selectedJoukkue != null)
            {
                observablePlayers.Clear();
                foreach (var player in selectedJoukkue.HaePelaajat())
                {
                    observablePlayers.Add(player);
                }
            }
        }

        private void RemPlayer(object sender, RoutedEventArgs e) //Remove a player.
        {
            var playerNumbertext = PelNumTB.Text;
            if (int.TryParse(playerNumbertext, out var playerNumber))
            {
                if (selectedJoukkue.HaePelaaja(playerNumber) != null)
                {
                    selectedJoukkue.PoistaPelaaja(playerNumber);
                    UpdateObservablePlayers();
                }
                
            }
        }
    }
}
