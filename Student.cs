using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomework
{
    public struct Student : IComparable
    {
        public string FIO { get; set; }
        public string Group { get; set; }
        public int AVGMark { get; set; }
        public int FamilyMemberSalary { get; set; }
        public SexTypes Sex { get; set; } 
        public StudyForms StudyForm { get; set; }

        public int CompareTo(object obj)
        {
            Student student = (Student)obj;
            return AVGMark.CompareTo(student.AVGMark);
        }
    }
}
