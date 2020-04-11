using System;

namespace Latihan_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mukhammad Tizar Prakoso", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 27, 16568, "Pemrogaman");
            teacher.GetNameAndAge();

            Student student = new Student("Tizar", 20, 2709, "Mukhammad.16@amikom.students.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();

        }

        internal class Person
        {
            private string Name;
            private int Age;
            private int ID;
            private string Status;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama Saya: {0}, Usia: {1} ", Name, Age, ID, Status, Email);
            public Person(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

        internal class Teacher
        {
            private string Name;
            private int Age;
            private int ID;
            private string Status;

            public void GetNameAndAge() => Console.WriteLine("Nama Guru: {0}, Usia: {1}, ID: {2}, Mengajar: {3} ", Name, Age, ID, Status);
            public Teacher(string Name, int Age, int ID, string Status)
            {
                this.Name = Name;
                this.Age = Age;
                this.ID = ID;
                this.Status = Status;
            }
        }

        internal class Student
        {
            private string Name;
            private int Age;
            private int ID;
            private string Email;

            public void GetNameAndAge() => Console.WriteLine("Nama Murid: {0}, Usia: {1}, ID: {2}, Email: {3} ", Name, Age, ID, Email);
            public Student(string Name, int Age, int ID, string Email)
            {
                this.Name = Name;
                this.Age = Age;
                this.ID = ID;
                this.Email = Email;
            }
        }

    }
}