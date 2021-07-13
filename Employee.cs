using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFORMHW3
{
    public class Employee
    {
        public Employee(string surName, string name, string fatherName, DateTime birthday, string birthPlace)
        {
            SurName = surName;
            Name = name;
            FatherName = fatherName;
            Birthday = birthday;
            BirthPlace = birthPlace;
        }

        public string SurName { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime Birthday { get; set; }
        public string BirthPlace { get; set; }
        public Employee()
        {

        }
    }
}
