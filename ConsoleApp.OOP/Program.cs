// See https://aka.ms/new-console-template for more information
using ConsoleApp.OOP.Classes.PersonDemo;
using ConsoleApp.OOP.Classes.ShapeDemo;

Console.WriteLine("******** - Classes and Objects - ***********");

//Define an object of type Person

Person person; // this will be null by default

Person baby = new Person();
baby.LastName = "Sui";
baby.FirstName = "Esther";
baby.DateOfBirth = new DateOnly(2023, 10, 29);

//Console.WriteLine($"{baby.FirstName} {baby.LastName}");

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();
var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);

var person1 = new Person("Developer", "One", new DateOnly(2000,10,31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "741852963");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();

var person2IdNumber = person2.GetIdNumber();
Console.WriteLine(person2IdNumber);

var teacher = new Teacher();
teacher.LastName = "Thompson";
teacher.FirstName = "Theresa";
teacher.DateOfBirth = new DateOnly(2023, 10, 29);

teacher.PrintFullName();
teacher.PrintInitials();
teacher.GenerateTaxNumber();
var teacherTaxNumber = teacher.GetTaxNumber();
Console.WriteLine($"{teacherTaxNumber}");
teacher.GenerateTeacherIdNumber();

var teacherIdNumber = teacher.GetIdNumber();    
Console.WriteLine(teacherIdNumber);

Student student = new();
student.LastName = "Gates";
student.FirstName = "Bill";
student.DateOfBirth = new DateOnly(2023, 10, 29);
student.PrintFullName();
student.PrintInitials();
student.GenerateTaxNumber();
student.GenerateStudentIdNumber();

var studentIdNumber = student.GetIdNumber();
Console.WriteLine(studentIdNumber);

//Ploygon polygon = new Polygon(); // compiler error
Rectangle rectangle = new(10,20);
var rectangleArea = rectangle.Area();
var rectanglePerimeter = rectangle.Perimeter();
rectangle.GetShapeName();
Console.WriteLine($"Rectangle perimeter is: {rectanglePerimeter}");
Console.WriteLine($"Rectangle area is: {rectangleArea}");

Square square = new(50);
var squareArea = square.Area();
Console.WriteLine($"Square area is: {squareArea}");

Cuboid cuboid = new Cuboid(1,5,7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();
Console.WriteLine($"Cuboid area is: {cuboidArea}");
Console.WriteLine($"Cuboid volume is: {cuboidVolume}");
Console.WriteLine($"Cuboid perimeter is: {cuboidPerimeter}");

Sphere sphere = new(7);
var sphereCircumference = sphere.Circumference();
var sphereVolume = sphere.Volume();
Console.WriteLine($"{nameof(Sphere)} Circumference is: {sphereCircumference}");
Console.WriteLine($"{nameof(Sphere)} volume is: {sphereVolume}");
