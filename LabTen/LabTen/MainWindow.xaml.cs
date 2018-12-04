using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace LabTen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Collections
        private ObservableCollection<Bike> Products;
        private ObservableCollection<Bike> Cart;
        private ObservableCollection<Bike> Filter;
        private double TotalCost;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Products = new ObservableCollection<Bike>();
            Cart = new ObservableCollection<Bike>();
            Filter = new ObservableCollection<Bike>();

            lstbxCart.ItemsSource = Cart;
            lstbxProducts.ItemsSource = Products;
            cmbbxBikeType.ItemsSource = Filter;

            Bike bk1 = new Bike(1234, "Adventure", 200.01, "Male");
            Bike bk2 = new Bike(1235, "Mountain Bike", 256.99, "Female");
            Bike bk3 = new Bike(1236, "Mountain Bike", 256.99, "Male");
            Bike bk4 = new Bike(1233, "Adventure", 200.01, "Female");
            Bike bk5 = new Bike(0728, "Hybrid Bike", 150, "Female");
            Bike bk6 = new Bike(0729, "Hybrid Bike", 150, "Male");

            Products.Add(bk5);
            Products.Add(bk6);
            Products.Add(bk4);
            Products.Add(bk1);
            Products.Add(bk2);
            Products.Add(bk3);

 

            TotalCost = 0;
        }

        private void BtnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (lstbxProducts.SelectedItem != null)
            {
                Bike temp = lstbxProducts.SelectedItem as Bike;
                TotalCost += temp.Cost;
                Cart.Add(temp);
                txbkTotalCost.Text = $"Total Cost:{TotalCost}";
            }

        }

        private void BtnRemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            if (lstbxCart.SelectedItem != null)
            {
                Bike temp = lstbxProducts.SelectedItem as Bike;
                TotalCost -= temp.Cost;
                Cart.Remove((Bike)lstbxCart.SelectedItem);
                txbkTotalCost.Text = $"Total Cost:{TotalCost}";
            }
        }
    }
}
