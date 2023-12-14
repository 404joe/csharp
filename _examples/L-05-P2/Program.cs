// Practice Lesson 5 Task 2

using System;

public class Student
{
    private int _grade;

    public int Grade
    {
        get { return _grade; }
        set
        {
            if (value >= 2 && value <= 6)
            {
                _grade = value;
            }
            else
            {
                Console.WriteLine("Invalid grade. Grade should be in the range [2 - 6].");
                // You can choose to throw an exception or handle the invalid input in another way if needed.
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        // Valid grade assignment
        student.Grade = 4;

        // Invalid grade assignment
        student.Grade = 7; // This will display the error message

        // Accessing the grade
        Console.WriteLine("Student's Grade: " + student.Grade);
    }
}
