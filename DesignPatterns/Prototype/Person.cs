using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public abstract Person Clone();
    }
}
