using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals_Operator_Overload
{
    public class Employee: Person
    {
        public int ID { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isSameEmployee = employee1.ID == employee2.ID;
            return isSameEmployee;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool notSameEmployee = employee1.ID != employee2.ID;
            return notSameEmployee;
        }

        public bool Equals(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, null))
            {
                return ReferenceEquals(employee2, null);
            }
            return Equals(employee1, employee2);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}
