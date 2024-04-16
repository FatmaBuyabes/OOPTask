
var fatma = new Student("Fatma", "MIS", 3.41);
fatma.PrintSummery();

var awdhah = new GraduteStudent("Awdhah", "Computer Engineer", 3.08, true);
awdhah.PrintGraduteInfo();
public class Student
{ 
    public string Name { get; set; }

    public string Major { get; set; }

    public double Gpa { get; set; }

    public Student(string name, string major, double gpa) //constructor
    {
        Name = name;
        Major = major;
        Gpa = gpa;
    }

    public void PrintSummery()
    {
        System.Console.WriteLine($"Student Name: {Name} \nMajor: {Major} \nGPA: {Gpa}");
    }


}

public class GraduteStudent : Student
{
    public GraduteStudent(string name, string major, double gpa, bool employee) : base(name, major, gpa)
    {
        Employee = employee;
    }

    public bool Employee { get; set; }

    public void PrintGraduteInfo()
    {
        Console.WriteLine($"\nStudent Name: {Name} \nMajor: {Major} \nGPA: {Gpa} \nIs employee: {Employee}");
    }

}


