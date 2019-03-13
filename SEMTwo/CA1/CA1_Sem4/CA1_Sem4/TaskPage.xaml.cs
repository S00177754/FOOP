using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Interaction logic for TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        static public ListBox lstbxTasks;

        public TaskPage()
        {
            InitializeComponent();
            LstBxTasks.ItemsSource = MainWindow.taskList;
            lstbxTasks = LstBxTasks;
        }

        private void BtnEditTask_Click(object sender, RoutedEventArgs e)
        {
            if(LstBxTasks.SelectedItem != null)
            {
                TaskEdit editWindow = new TaskEdit(LstBxTasks.SelectedItem as Task);
                editWindow.ShowDialog();
                BtnCompleteTask.Content = "Complete Task";
                TaskRefresh();
            }
        }

        private void BtnRemoveTask_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxTasks.SelectedItem != null)
            {
                MainWindow.taskList.Remove(LstBxTasks.SelectedItem as Task);
                BtnCompleteTask.Content = "Complete Task";
                TaskRefresh();
            }
        }

        private void BtnCompleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (LstBxTasks.SelectedItem != null)
            {
                Task temp = MainWindow.taskList.Where(task => task.Equals(LstBxTasks.SelectedItem as Task)).First();
                temp.CompleteTask();

                TaskRefresh();
            
                if (temp.Completed == "Completed")
                {
                    BtnCompleteTask.Content = "Uncomplete Task";
                }
                else
                {
                    BtnCompleteTask.Content = "Complete Task";
                }
            }
        }

        private void LstBxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        static public void TaskRefresh()
        {
            lstbxTasks.ItemsSource = null;
            lstbxTasks.ItemsSource = MainWindow.taskList;
        }
    }
}
