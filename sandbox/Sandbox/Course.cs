// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");
//     }
// }

// See https://aka.ms/new-console-template for more information



using System.Security.Cryptography.X509Certificates;

static void Main(string[] args)
{
    Course course1 = new Course();
    course1._classCode = "CSE 210";
    course1._className = "Programing with Classes";
    course1._credits = 2;
    course1._color = "green";

    // Class
    // attributes
    // method / behaviors
    course1.Display();
}

Public void Display()
    {
        Console.WriteLine($"{_classCode} {_className} {_credits} {_color}");
    }
class Course
{
    public string _classCode;

    public string _className;

    public int _credits;

    public string _color;
}