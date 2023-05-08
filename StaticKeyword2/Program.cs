using System;

namespace StaticKeyword2
{
    class Student
    {
        static public string universityName = "Khmelnytsksy National University";
        public string studentName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.studentName = "Beverley";

            //Calls instances variable
            Console.WriteLine("Name: " + s1.studentName);
            //calls static variable
            Console.WriteLine("University: " + Student.universityName);

            Student s2 = new Student();
            s2.studentName = "Nastya";

            //calls instance variable
            Console.WriteLine("Name: " + s2.studentName);
            //calls static variable
            Console.WriteLine("University: " + Student.universityName);

            Student s3 = new Student();
            s3.studentName = "Bodya";

            Console.WriteLine("Name: " + s3.studentName);
            Console.Write("University: " + Student.universityName);

            Console.ReadLine();
        }
    }
}
