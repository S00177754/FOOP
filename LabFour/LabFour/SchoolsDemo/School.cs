using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsDemo
{
    class School: IComparable<School>
    {
        private string _schoolName;
        public string schoolName
        {
            get { return _schoolName; }
            set { _schoolName = value; }
        }

        private int _schoolStudentNumbers;
        public int schoolStudentNumbers
        {
            get { return _schoolStudentNumbers; }
            set { _schoolStudentNumbers = value; }
        }

        public int CompareTo(School school)
        {
            return _schoolStudentNumbers;
        }
    }
}
