static void Main(string[] args)
{
    Person person = new person();
    person.Name = "Tizar";
    person.Age = 20;
    person.GetNameandAge();

    Teacher teacher = new Teacher();
    teacher.Name = "Kamarudin";
    teacher.Age = 27;
    teacher.TeacherId = "Pemrograman";
    person.GetNameandAge();

    Student student = new student();
    student.Name = "M_Tizar_P";
    student.Age = 19;
    student.StudentId = "19.11.2709";
    student.Email = "mukhammad.16@amikom.students.ac.id";
    person.GetNameandAge();

    Console.Readkey();
}