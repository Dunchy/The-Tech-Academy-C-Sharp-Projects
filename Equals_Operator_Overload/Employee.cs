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
    }
}
