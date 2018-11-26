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
using Microsoft.Win32;

using System.Diagnostics;
using System.Collections;

namespace ExerciseSeven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables
        List<Player> players = new List<Player>();
        
        
        //brush.ImageSource = new BitmapImage(new Uri("Images/ContentImage.png", UriKind.Relative));
        

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

        //METHODS//
        public void ImportFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.DefaultExt = ".txt";
            Nullable<bool> result = fileDialog.ShowDialog();

            if (result == true)
            {
                // Open document 
                string filename = fileDialog.FileName;

                FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                
                string dataInput;
                string[] dataSet = new string[6];
                dataInput = sr.ReadLine();

                while(dataInput != null)
                {
                    dataSet = dataInput.Split(',');
                    players.Add(new Player(dataSet[0], dataSet[1], dataSet[2], int.Parse(dataSet[3]), int.Parse(dataSet[4]), int.Parse(dataSet[5]) ) );
                    listbxPLayerList.Items.Add(dataSet[0]);
                    dataInput = sr.ReadLine();
                    //Debug.WriteLine("Read new line");
                }

                sr.Close();
            }
        }

        public void Export(string operation)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".txt";
            Nullable<bool> result = saveFileDialog.ShowDialog();

            if(result == true)
            {
                string filename = saveFileDialog.FileName;
                string exportLine;

                FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                if (operation == "Single")
                {
                    exportLine = players[listbxPLayerList.SelectedIndex].FormatExport();
                    sw.WriteLine(exportLine);
                }
                else if (operation == "All")
                {
                    for (int i = 0; i < listbxPLayerList.Items.Count; i++)
                    {
                        exportLine = players[i].FormatExport();
                        sw.WriteLine(exportLine);
                    }
                    
                    //exportLine = players[counter].FormatExport();

                    //while(exportLine != null)
                    //{
                    //sw.WriteLine(exportLine);
                    //exportLine = players[counter].FormatExport();
                    //counter++;
                    //}
                }

                    sw.Close();
            }
        }

        private void BtnImport_Click(object sender, RoutedEventArgs e)
        {
            ImportFile();
        }

        private void BtnExportSelected_Click(object sender, RoutedEventArgs e)
        {
            Export("Single");
        }

        private void BtnExportList_Click(object sender, RoutedEventArgs e)
        {
            Export("All");
        }

        private void ListbxPLayerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
        public Player(string name) : this(name, "Fighter", "Human", 12, 8, 8)
        {
        }

        public Player(string name,string plyClass,string race,int ac, int maxHealth, int health)
        {
            Name = name;
            Class = plyClass;
            Race = race;
            AC = ac;
            MaxHealth = maxHealth;
            Health = health;
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
        public string FormatExport()
        {
            return string.Format($"{Name},{Class},{Race},{AC},{MaxHealth},{Health}");
        }

        
    }
}
