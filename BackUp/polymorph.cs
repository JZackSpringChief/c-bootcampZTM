//Inheritance
// using System.Reflection.Metadata.Ecma335;

// Person p1 = new("Aric");
// Employee p2 = new("Zack", "CEO");

// Console.WriteLine($"{p1.Name}: {p1.GetId()}");
// Console.WriteLine($"{p2.Name}: {p2.GetId()}");

// public interface ISalary
// {
//     decimal GetSalary();
// }
//can use be set as public "sealed" class Person to prevent inheritance
// public class Person
// {
//     public string Name { get; set; }
//     public Person(string name)
//     {
//         Name = name;
//     }
//     public virtual string GetId()
//     {
//         return Name.ToLower();
//     }
// }

// public class Employee : Person, ISalary
// {
//     public string Role { get; set; }
//     public Employee(string name, string role) : base(name)
//     {
//         Role = role;
//     }
//     public override string GetId()
//     {
//         return $"{Role.ToLower()}-{base.GetId()}";
//     }

//     public decimal GetSalary()
//     {
//         return 6000;
//     }
// }

// Person p1 = new();
// Person p2 = new Employee();
// Person p3 = new Customer();

// p1.Greeting();
// p2.Greeting();
// p3.Greeting();



// public class Person
// {
//     public virtual void Greeting()
//     {
//         Console.WriteLine("I am a reg");
//     }
// }
// public class Employee : Person
// {
//     public override void Greeting()
//     {
//         Console.WriteLine("I am an Employee");
//     }
// }
// public class Customer : Person
// {
//     public override void Greeting()
//     {
//         Console.WriteLine("I am a Customer");
//     }
// }
