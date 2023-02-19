using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Members { get; set; }

        public Family()
        {
            this.Members = new List<Person>();
        }

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestGuy = Members.OrderByDescending(m => m.Age).FirstOrDefault();

            return oldestGuy;
        }

        public Person[] GerOverThirty()
        {
            Person[] overThirty = Members.OrderBy(m => m.Name).Where(m => m.Age > 30).ToArray();

            return overThirty;
        }
    }
}
