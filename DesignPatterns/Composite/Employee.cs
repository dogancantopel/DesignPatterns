using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = new List<IPerson>();
        public string Name { get; set; }

        public void AddSubOrdinate(IPerson person)
        {
            _subordinates.Add(person);
        }
        public void RemoveSubOrdinate(IPerson person)
        {
            _subordinates.Remove(person);
        }
        public IPerson GetSubOrdinate(int index)
        {
            return _subordinates[index];
        }
        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
