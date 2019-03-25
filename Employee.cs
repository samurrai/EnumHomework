using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomework
{
    public struct Employee : IComparable
    {
        public string Surname { get; set; }
        public Vacancies Vacancy { get; set; }
        public int Salary { get; set; }
        public int[] EmploymentDate { get; set; }

        public int CompareTo(Employee obj)
        {
            return Surname.CompareTo(obj.Surname);
        }

        public int CompareTo(object obj)
        {
            Employee tmp = (Employee)obj;
            return Surname.CompareTo(tmp.Surname);
        }
    }
}
