using System;

namespace UniversityClass
{
    class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();
            student.FirstName = "Егор";
            student.MiddleName = "Комаров";
            student.LastName = "Евгеньевич";
            student.Age = 18;
            student.Group = "ПС-12";
            return student;
        }

        static Teacher GetTeacher()
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Галина";
            teacher.MiddleName = "Юрьевна";
            teacher.LastName = "Сметановка";
            teacher.Age = 55;
            teacher.Subject = "Математика";
            return teacher;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Фамилия: {student.LastName}");
            Console.WriteLine($"Имя: {student.FirstName}");
            Console.WriteLine($"Отчество: {student.MiddleName}");
            Console.WriteLine($"Возраст: {student.Age}");
            Console.WriteLine($"Группа: {student.Group}");
        }

        static Subjects GetSubjects()
        {
            Subjects subjects = new Subjects();
            subjects.FirstSubject = "Право";
            subjects.SecondSubject = "Аналитическая геометрия";
            subjects.ThirdSubject = "ОП";
            subjects.FourthSubject = "Физика";
            subjects.FifthSubject = "Математика";
            return subjects;
        }

        static void Print(Teacher teacher)
        {
            Console.WriteLine("Информация о преподавателе:");
            Console.WriteLine($"Фамилия: {teacher.LastName}");
            Console.WriteLine($"Имя: {teacher.FirstName}");
            Console.WriteLine($"Отчество: {teacher.MiddleName}");
            Console.WriteLine($"Возраст: {teacher.Age}");
            Console.WriteLine($"Предмет: {teacher.Subject}");
        }

        static void Print(Subjects subjects)
        {
            Console.WriteLine("Список занятий:");
            Console.WriteLine($"1.{subjects.FirstSubject}");
            Console.WriteLine($"2.{subjects.SecondSubject}");
            Console.WriteLine($"3.{subjects.ThirdSubject}");
            Console.WriteLine($"4.{subjects.FourthSubject}");
            Console.WriteLine($"5.{subjects.FifthSubject}");
        }
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
            var firstTeacher = GetTeacher();
            Print(firstTeacher);
            var SubjectList = GetSubjects();
            Print(SubjectList);
        }
    }
}
