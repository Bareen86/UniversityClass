using System;

namespace UniversityClass
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.firstName = "Егор";
            student.middleName = "Комаров";
            student.lastName = "Евгеньевич";
            student.age = 18;
            student.id = Guid.NewGuid();
            student.group = "ПС-12";
            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Id: {student.id}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Возраст: {student.age}");
            Console.WriteLine($"Группа: {student.group}");
        }    
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}
