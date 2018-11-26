using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    class Member
    {
        //Variables
        public enum MemberType {Full,OffPeak,Student,OAP}

        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Address { get; private set; }
        public MemberType Type { get; private set; }
        public int Year { get; private set; }

        //Constructors
        public Member():this("John Doe","0801234567","1 O'Connell Road, Sligo",MemberType.Full,Utility.RandomNext(2000,2015))
        {
        }

        public Member(string name, string phone, string address, MemberType type,int year)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Type = type;
            Year = year;
        }

        //Overrides
        public override string ToString()
        {
            return string.Format(Name);
        }
    }
}
