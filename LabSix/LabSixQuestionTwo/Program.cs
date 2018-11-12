using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSixQuestionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bk = new Book("123AB", "Adventure", "Benji Bardle", 20.30m);
            TextBook TxBk = new TextBook("456AB", "Misadventure", "Benji Bardle", 20.30m,"2017");
            TextBook bk = new TextBook("124DE", "Begin", "Michael Bardle", 20.30m, "2017");
        }
    }
}