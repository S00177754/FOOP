using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ExerciseSeven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables
        List<Player> players = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Creates New Player based on string in input field
        private void BtnPlayerAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxAddPlayer.Text != null && txtboxAddPlayer.Text != "")
            {
                listbxPLayerList.Items.Add(txtboxAddPlayer.Text);
                players.Add(new Player(txtboxAddPlayer.Text));
            }
        }

        //Deletes and removes player from list 
        private void BtnDeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            if(listbxPLayerList.SelectedItem != null)
            {
                int selectedIndex = listbxPLayerList.SelectedIndex;
                listbxPLayerList.Items.RemoveAt(selectedIndex);
                players.RemoveAt(selectedIndex);
            }
        }

        //Loads player data from list and populates fields
        private void BtnViewPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (listbxPLayerList.SelectedItem != null)
            {
                int selectedIndex = listbxPLayerList.SelectedIndex;

                //Data fields filled by following chunk of code.
                lblPlayerName.Content = $"Name: {players[selectedIndex].Name}";
                txtblkClass.Text = (players[selectedIndex].Class).ToString();
                txtblkRace.Text = (players[selectedIndex].Race).ToString();
                txtblkAC.Text = (players[selectedIndex].AC).ToString();
                txtblkMaxHealth.Text = (players[selectedIndex].MaxHealth).ToString();
                txtblkHealth.Text = (players[selectedIndex].Health).ToString();
            }
            else
            {
                lblPlayerName.Content = "Name:";
            }
        }

        //updates fields so that values are not reset on view beingclicked
        private void BtnSavePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (listbxPLayerList.SelectedItem != null)
            {
                int selectedIndex = listbxPLayerList.SelectedIndex;
                players[selectedIndex].UpdatePlayer(txtblkClass.Text, txtblkRace.Text, int.Parse(txtblkAC.Text), int.Parse(txtblkMaxHealth.Text), int.Parse(txtblkHealth.Text));
            }
        }
    }

    public class Player
    {
        //Variables - Player Stats
        public string Name { get; private set; }
        public string Class { get; private set; }
        public string Race { get; private set; }
        public int AC { get; private set; }
        public int MaxHealth { get; private set; }
        public int Health { get; private set; }

        //Constructor
        public Player(string name)
        {
            Name = name;
            Class = "Fighter";
            Race = "Human";
            AC = 12;
            MaxHealth = 6;
            Health = 6;
        }

        //Methods
        public void UpdatePlayer(string plyClass,string race, int ac,int maxHealth, int health)
        {
            Class = plyClass;
            Race = race;
            AC = ac;
            MaxHealth = maxHealth;
            Health = health;

        }

        /// <summary>
        /// Creates string in csv format for exporting of data via text file
        /// </summary>
        public string FormatExport(Player pl)
        {
            return string.Format($"{Name},{Race},{AC},{MaxHealth},{Health}");
        }
    }
}
