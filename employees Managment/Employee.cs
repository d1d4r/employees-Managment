using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees_Managment
{
    internal class Employee
    {
        public String ID { get; set; }
        public String Name { get; set; }

        public String RFID { get; set; }
        public String Salary { get; set; }

        public Employee(string iD, string name, string rFID, string salary)
        {
            ID = iD;
            Name = name;
            RFID = rFID;
            Salary = salary;
        }
    }
}
