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

namespace ExerciseSeven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlayerAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxAddPlayer.Text != null && txtboxAddPlayer.Text != "")
            {
                Player ply = new Player(txtboxAddPlayer.Text);
                listbxPLayerList.Items.Add(ply.Name);
            }
        }

        private void BtnDeletePlayer_Click(object sender, RoutedEventArgs e)
        {
            if(listbxPLayerList.SelectedItem != null)
            {
                listbxPLayerList.Items.RemoveAt(listbxPLayerList.Items.IndexOf(listbxPLayerList.SelectedItem));
                listbxPLayerList.SelectedItem = null;
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
    }
}
