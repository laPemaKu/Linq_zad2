using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
	public static void Main()
	{
        Student[] studentArray = {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        var linqStudents = from student in studentArray
                           orderby student.Age descending
                           select student;

        foreach(var student in linqStudents)
        {
            Console.WriteLine(student.Age);
        }

        Console.ReadKey();
	}
}


public class Student
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
    public int Age { get; set; }
}