using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFive
{
    class Team : IComparable
    {
        //Variables
        private string teamName;
        public string TeamName { get { return teamName; } }

        private int numberOfWins = 0;
        public int NumberOfWins { get { return numberOfWins; } }

        private int numberOfDraws = 0;
        public int NumberOfDraws { get { return numberOfDraws; } }

        private int numberOfLosses = 0;
        public int NumberOfLosses { get { return numberOfLosses; } }

        private int numberOfGames = 0;
        public int NumberOfGames { get { return numberOfGames; } }

        private int points = 0;
        public int Points { get { return points; } }

        public enum Result { Win, Draw, Lose };

        //Constructor
        public Team(string NameOfTeam)
        {
            teamName = NameOfTeam;
        }

        //Methods
        public void AddResult(Result result)
        {
            numberOfGames++;
            if (result == Result.Win)
            {
                numberOfWins++;
                points += 3;
            }
            else if(result == Result.Draw)
            {
                numberOfDraws++;
                points += 1;
            }
            else if(result == Result.Lose)
            {
                numberOfLosses++;
            }
            else
            {
                Console.WriteLine("Invalid Result");
                numberOfGames--;
            }

            
        }

        public int CompareTo(object team)
        {
            //team = (Team)team;

            if (team == null)
                return 1;

            Team otherTeam = team as Team;

            if (otherTeam != null)
                return this.Points.CompareTo(otherTeam.Points);
            else
                throw new ArgumentException("Object is not a Team");

        }
    }
}
