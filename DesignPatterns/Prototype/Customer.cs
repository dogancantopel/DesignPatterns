using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Customer:Person
    {
        public string City { get; set; }
        public int CustomerId { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
