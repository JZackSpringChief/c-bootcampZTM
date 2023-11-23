// int[] array1 = new int[4]; //we can use var;
// array1[0] = 7;
// array1[1] = 14;
// array1[2] = 21;
// array1[3] = 14;

// Console.WriteLine(array1[3]);

// //better way to assain array
// var array2 = new int[] { 7, 14, 21, 14 };
// Console.WriteLine(array2[2]);

// //alternative syntax
// int[] array3 = { 7, 14, 21, 14 };

// // uninitialized elements;
// int[] array4 = new int[5];
// Console.WriteLine(array4[0]);

// Person[] persons = new Person[2];
// persons[0] = new Person("Zack");
// persons[1] = new Person("Janna");

// Console.WriteLine(persons);
// var person0 = persons[0];
// Console.WriteLine(person0.Name);

// foreach (Person person in persons)
// {
//     Console.WriteLine(person.Name);
// }


// public class Person
// {
//     public Person(string name)
//     {
//         Name = name;
//     }
//     public string Name { get; set; }
// }