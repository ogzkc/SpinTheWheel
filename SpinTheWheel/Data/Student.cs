using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinTheWheel.Data
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }

        public Student Clone()
        {
            return new Student()
            {
                FirstName = FirstName,
                LastName = LastName,
                Number = Number
            };
        }
    }
}
