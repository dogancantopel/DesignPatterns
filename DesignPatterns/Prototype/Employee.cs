using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Employee:Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
