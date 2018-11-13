using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Game
    {
        //Variables
        public readonly string Name;
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        //Constructors
        public Game(string name,decimal price,DateTime releaseDate)
        {
            Name = name;
            Price = price;
            ReleaseDate = releaseDate;
        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {
        }

        public Game() : this("", 0)
        {
        }

        //Methods
        public override string ToString()
        {
            return string.Format($"Name: {Name}   Price: {Price}   Release Date: {ReleaseDate.ToShortDateString()}");
        }
    }

    class ComputerGame : Game
    {
        //Variables
        public string PEGI;

        //Constructors

    }
}
