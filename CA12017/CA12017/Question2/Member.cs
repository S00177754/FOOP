using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MemberID { get; set; }
        public bool MembershipStatus = true;

        public Member(string firstName, string lastName, int age, string ID)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MemberID = ID;
            MembershipStatus = false;
        }

        public override string ToString()
        {
            Console.WriteLine($"First Name: { FirstName}");
            Console.WriteLine($"Last Name: { LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {MemberID}");
            Console.WriteLine($"Membership Status: {MembershipStatus}");
            return base.ToString();
        }
    }
}
