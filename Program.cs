using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Employee[] employees = new Employee[10];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].Surname = "Ruslan " + i;
                employees[i].Salary = random.Next();

                employees[i].Vacancy = Vacancies.Clerk;

                employees[i].EmploymentDate = new int[3];
                employees[i].EmploymentDate[0] = 20;
                employees[i].EmploymentDate[1] = 02;
                employees[i].EmploymentDate[2] = 2019;

                if (i == 9)
                {
                    employees[i].Vacancy = Vacancies.Boss;

                    employees[i].EmploymentDate[0] = 15;
                    employees[i].EmploymentDate[1] = 01;
                    employees[i].EmploymentDate[2] = 2003;
                }
                if (i == 5)
                {
                    employees[i].Vacancy = Vacancies.Manager;

                    employees[i].EmploymentDate[0] = 23;
                    employees[i].EmploymentDate[1] = 04;
                    employees[i].EmploymentDate[2] = 2003;
                }
                if (i == 3)
                {
                    employees[i].Vacancy = Vacancies.Salesman;

                    employees[i].EmploymentDate[0] = 01;
                    employees[i].EmploymentDate[1] = 11;
                    employees[i].EmploymentDate[2] = 2003;
                }
            }
            Console.WriteLine("All employees: ");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].Surname);
                Console.WriteLine(employees[i].Vacancy);
                Console.WriteLine(employees[i].Salary);
                Console.Write(employees[i].EmploymentDate[0] + "/");
                Console.Write(employees[i].EmploymentDate[1] + "/");
                Console.WriteLine(employees[i].EmploymentDate[2]);
                Console.WriteLine();
            }

            Console.WriteLine("Managers: ");

            int amountOfClerks = 0;
            int salaryOfClerks = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Clerk)
                {
                    amountOfClerks++;
                    salaryOfClerks += employees[i].Salary;
                }
            }

            int avgSalaryOfClerks = salaryOfClerks / amountOfClerks;


            int amountOfManagers = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Manager && employees[i].Salary > avgSalaryOfClerks)
                {
                    amountOfManagers++;
                }
            }

            Employee[] managers = new Employee[amountOfManagers];
            for (int i = 0, j = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Manager && employees[i].Salary > avgSalaryOfClerks)
                {
                    managers[j].Surname = employees[i].Surname;
                    managers[j].Salary = employees[i].Salary;
                    managers[j].Vacancy = employees[i].Vacancy;

                    managers[j].EmploymentDate = new int[3];
                    managers[j].EmploymentDate[0] = employees[i].EmploymentDate[0];
                    managers[j].EmploymentDate[1] = employees[i].EmploymentDate[1];
                    managers[j].EmploymentDate[2] = employees[i].EmploymentDate[2];
                    j++;
                }
            }
            Array.Sort(managers);
            foreach (var manager in managers)
            {
                Console.WriteLine(manager.Surname);
                Console.WriteLine(manager.Vacancy);
                Console.WriteLine(manager.Salary);

                Console.Write(manager.EmploymentDate[0] + "/");
                Console.Write(manager.EmploymentDate[1] + "/");
                Console.WriteLine(manager.EmploymentDate[2]);
                Console.WriteLine();
            }

            int indexOfBoss = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Vacancy == Vacancies.Boss)
                {
                    indexOfBoss = i;
                    break;
                }
            }

            int amountOfEmployeesAfterBoss = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].EmploymentDate[2] > employees[indexOfBoss].EmploymentDate[2] &&
                    employees[i].EmploymentDate[1] > employees[indexOfBoss].EmploymentDate[1] &&
                    employees[i].EmploymentDate[0] > employees[indexOfBoss].EmploymentDate[0]
                    )
                {
                    amountOfEmployeesAfterBoss++;
                }
            }

            Employee[] employeesAfterBoss = new Employee[amountOfEmployeesAfterBoss];

            for (int i = 0, j = 0; i < employees.Length; i++)
            {
                if (employees[i].EmploymentDate[2] > employees[indexOfBoss].EmploymentDate[2] &&
                    employees[i].EmploymentDate[1] > employees[indexOfBoss].EmploymentDate[1] &&
                    employees[i].EmploymentDate[0] > employees[indexOfBoss].EmploymentDate[0]
                    )
                {
                    employeesAfterBoss[j].Surname = employees[i].Surname;
                    employeesAfterBoss[j].Vacancy = employees[i].Vacancy;
                    employeesAfterBoss[j].Salary = employees[i].Salary;

                    employeesAfterBoss[j].EmploymentDate = new int[3];

                    employeesAfterBoss[j].EmploymentDate[0] = employees[i].EmploymentDate[0];
                    employeesAfterBoss[j].EmploymentDate[1] = employees[i].EmploymentDate[1];
                    employeesAfterBoss[j].EmploymentDate[2] = employees[i].EmploymentDate[2];

                    j++;
                }
            }

            Array.Sort(employeesAfterBoss);

            Console.WriteLine("Employees after boss: ");

            foreach (var employee in employeesAfterBoss)
            {
                Console.WriteLine(employee.Surname);
                Console.WriteLine(employee.Vacancy);
                Console.WriteLine(employee.Salary);

                Console.Write(employee.EmploymentDate[0] + "/");
                Console.Write(employee.EmploymentDate[1] + "/");
                Console.WriteLine(employee.EmploymentDate[2]);
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------");

            List<Student> students = new List<Student>();
            students.Add(new Student
            {
                FIO = "Andrey", 
                AVGMark = 3, 
                FamilyMemberSalary = 100, 
                Group = "sdp", 
                Sex = SexTypes.Male, 
                StudyForm = StudyForms.FullTime
            });
            students.Add(new Student
            {
                FIO = "Olga",
                AVGMark = 4,
                FamilyMemberSalary = 1000,
                Group = "sdb",
                Sex = SexTypes.Female,
                StudyForm = StudyForms.FullTime
            });
            students.Add(new Student
            {
                FIO = "Katya",
                AVGMark = 5,
                FamilyMemberSalary = 30000,
                Group = "sdp",
                Sex = SexTypes.Female,
                StudyForm = StudyForms.FullTime
            });
            students.Add(new Student
            {
                FIO = "Petr",
                AVGMark = 2,
                FamilyMemberSalary = 1000000,
                Group = "sdb",
                Sex = SexTypes.Male,
                StudyForm = StudyForms.External
            });

            List<Student> univercityHostel = new List<Student>();
            int minimalSalary = 11280;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].FamilyMemberSalary < minimalSalary * 2)
                {
                    univercityHostel.Add(students[i]);
                    students.RemoveAt(i);
                }
            }
            students.Sort();
            foreach (var s in students)
            {
                Console.WriteLine(s.FIO);
            }
            univercityHostel.AddRange(students);
            foreach (var student in univercityHostel)
            {
                Console.WriteLine(student.FIO);
            }
        }
    }
}
