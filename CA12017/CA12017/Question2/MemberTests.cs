using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class MemberTests
    {
        static void Main(string[] args)
        {
            //Variables
            Member mem = new Member("Ronan", "Cassidy", 19,"S00177754");
            Member[] members = new Member[5];

            members[0] = new Member("Ronan", "Cassidy", 19, "S00177754");
            members[1] = new Member("Ronan", "Cassidy", 20, "S00177753");
            members[2] = new Member("Ronan", "Cassidy", 21, "S00177752");
            members[3] = new Member("Ronan", "Cassidy", 22, "S00177751");
            members[4] = new Member("Ronan", "Cassidy", 23, "S00177750");

            mem.ToString();

            Console.ReadKey();
        }
    }
}
