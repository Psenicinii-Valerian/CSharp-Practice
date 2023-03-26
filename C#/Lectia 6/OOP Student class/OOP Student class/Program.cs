using System.Runtime.CompilerServices;
using System.Linq;
using System.Net;

namespace OOP_Student_class
{
    /*    
        class Player
        {
            public string userName;
            public int age;

            public void showData()
            {
                Console.WriteLine("Hello");
            }

            public int getBirthYear() { return 2023 - age; }

        }
    */

    class Student
    {
        public string name;
        public string lastname;
        public string email;
        public int birthYear;
        public string group;
        public int[] marks;


        public Student(string name, string lastname, string email, int birthYear, string group, int[] marks)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.birthYear = birthYear;
            this.group = group;
            this.marks = marks;
        }


        public void getStudentData()
        {
            Console.WriteLine($"{this.name} {this.lastname}, email:: {this.email}, G-{this.group}");
        }

        public double avgMark()
        {
            double result = this.marks.Sum() / (this.marks.Count() + 0.0);
            // decimal decResult = Convert.ToDecimal(result);
            return Math.Round(result, 2);
        }
    }


    class Employee
    {
        string name;
        string lastname;
        string email;
        int birthYear;
        int experience;
        string industry;
        string position;
        int salary;
        bool hasKids;

        public Employee(string name, string lastname, string email, int birthYear, int experience, string industry, string position, int salary, bool hasKids)
        {
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.birthYear = birthYear;
            this.experience = experience;
            this.industry = industry;
            this.position = position;
            this.salary = salary;
            this.hasKids = hasKids;
        }

        public void showData()
        {
            Console.WriteLine($"Name: {this.name}, Lastname: {this.lastname}, Email: {this.email}, " +
                              $"Age: {2023 - this.birthYear} years");
        }

        public void showEmployee()
        {
            Console.WriteLine($"Name: {this.name}, Lastname: {this.lastname}, Experience: {this.experience} years, " +
                              $"Industry: {this.industry}, Position: {this.position}");
        }

        public void showSalary()
        {
            Console.WriteLine($"Industry: {this.industry}, Position: {this.position}, Experience: {this.experience} years, " +
                              $"Salary: {this.salary}$$");
        }

        public void hourSalary()
        {
            Console.WriteLine($"Hour salary: {Math.Round(this.salary / (24 * 10 + 0.0), 2)}$$");
        }

        public void dailySalary()
        {
            Console.WriteLine($"Daily salary: {Math.Round(this.salary / (double)24, 2)}$$");
        }

        public void yearSalary()
        {
            if (this.hasKids)
            {
                Console.WriteLine($"Year salary: {this.salary * 12 + 10000}$$");
            }
            else
            {
                Console.WriteLine($"Year salary: {this.salary * 12}$$");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Player p1 = new Player();
                p1.userName = "Snow";
                p1.age = 20;

                //Console.WriteLine($"{p1.userName} {p1.age}");
                //p1.showData();

                Console.WriteLine(p1.getBirthYear());
            */

            Student s1 = new Student("Mihai", "Micu", "micu@gmail.com", 2000, "2020IT", new int[] { 10, 12, 11, 9, 8, 12 });
            s1.getStudentData();
            Console.WriteLine($"Average Mark:: {s1.avgMark()}");


            // TASK ::
            /* 
                Clasa Employee (name, lastname, email, birthYear, experience(stagiu de munca), industry, position, 
                                salary(month), hasKids(bool))

                showData() -> Afiseaza name, lastname, email, varsta
                showEmployee() -> Afiseaza name, lastname, experience, industry, position
                showSalary() -> Afiseaza industry, position, experiece, salary
                hourSalary() -> Afisati salariul pe ora, daca persoana munceste 24 de zile din luna a cate 10 ore zilnic
                dailySalary()
                yearSalary() -> daca are copii bonus 10000 MDL.
            */

            Console.WriteLine("\n******************TASK******************\n");

            Employee emp = new Employee("John", "Smith", "jsmith4@gmail.com", 1999, 5, "IT", "Software developer", 3500, true);
            emp.showData();
            emp.showEmployee();
            emp.showSalary();
            emp.hourSalary();
            emp.dailySalary();
            emp.yearSalary();
        }
    }
}