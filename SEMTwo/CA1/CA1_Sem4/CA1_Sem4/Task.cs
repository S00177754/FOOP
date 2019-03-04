using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CA1_Sem4
{
    public enum TaskCategory { Misc, Birthday, School, Work, Personal };
    public enum PriorityLevel { Low, Medium, High, Urgent };

    public class Task : IComparable
    {
        //Variables
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskCategory Category { get; set; }
        public DateTime DueDate { get; set; }
        public string Date { get; set; }
        public PriorityLevel Priority { get; set; }
        public List<string> Labels { get; set; }
        public string Responsibility { get; set; }
        public string Completed { get; set; } = "Not Completed";
        public SolidColorBrush BackgroundColor { get; set; }

        //Constructor
        public Task(string title,string description,TaskCategory category,DateTime dueDate,PriorityLevel priority, string labels,string responsibility)
        {
            Title = title;
            Description = description;
            Category = category;
            DueDate = dueDate;
            Date = DueDate.ToShortDateString();
            Priority = priority;
            Responsibility = responsibility;
            Labels = new List<string>();
            Labels = (labels.Split(',')).ToList<string>();

            

            switch (Priority)
            {
                case PriorityLevel.Low:
                    BackgroundColor = Brushes.White;
                    break;
                case PriorityLevel.Medium:
                    BackgroundColor = Brushes.Yellow;
                    break;
                case PriorityLevel.High:
                    BackgroundColor = Brushes.Orange;
                    break;
                case PriorityLevel.Urgent:
                    BackgroundColor = Brushes.DarkRed;
                    break;
            }
        }

        public void CompleteTask()
        {
            Completed = "Completed";
        }

        public int CompareTo(object obj)
        {
            return DueDate.CompareTo(obj);
        }
    }
}
