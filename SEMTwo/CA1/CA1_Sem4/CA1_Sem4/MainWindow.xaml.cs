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

namespace CA1_Sem4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public ObservableCollection<Task> taskList = new ObservableCollection<Task>();
        static public ObservableCollection<string> UserList = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeApp();
            
        }

        private void InitializeApp()
        {
            UserList.Add("None");

            CmbBxCategory.ItemsSource = Enum.GetValues(typeof(TaskCategory));
            CmbBxPriority.ItemsSource = Enum.GetValues(typeof(PriorityLevel));
            CmbBxUser.ItemsSource = UserList;
            CmbBxCategory.SelectedIndex = 0;
            CmbBxPriority.SelectedIndex = 0;
            CmbBxUser.SelectedIndex = 0;

           

        }

        private void BtnAddEvent_Click(object sender, RoutedEventArgs e)
        {
                TaskCategory category;
                PriorityLevel priority;
                switch (CmbBxCategory.Text)
                {
                    case "Personal":
                        category = TaskCategory.Personal;
                        break;

                    case "School":
                        category = TaskCategory.School;
                        break;

                    case "Work":
                        category = TaskCategory.Work;
                        break;

                    case "Birthday":
                        category = TaskCategory.Birthday;
                        break;

                    default:
                        category = TaskCategory.Misc;
                        break;
                }
                switch (CmbBxCategory.Text)
                {
                    case "Low":
                        priority = PriorityLevel.Low;
                        break;

                    case "Medium":
                        priority = PriorityLevel.Medium;
                        break;

                    case "High":
                        priority = PriorityLevel.High;
                        break;

                    case "Urgent":
                        priority = PriorityLevel.Urgent;
                        break;

                    default:
                        priority = PriorityLevel.Low;
                        break;
                }
            if (TxtBkTitle.Text != null && TxtBkDescription.Text != null && DatePckEvent.SelectedDate != null && TxtBkLabels.Text != null && CmbBxUser.Text != null) 
            {
                taskList.Add(new Task(
                    TxtBkTitle.Text, TxtBkDescription.Text, category, DatePckEvent.SelectedDate.HasValue == true ? (DateTime)DatePckEvent.SelectedDate : new DateTime(),
                    priority, TxtBkLabels.Text, CmbBxUser.Text));
            }
        }

       
    }
}
