namespace test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter your Name: ");
            // string? name = Console.ReadLine();

            // Console.WriteLine($"Hello, {name}");
            // bool enabled = false;
            // Console.WriteLine($"bool: {enabled}");
            // enabled = true;
            // Console.WriteLine($"bool: {enabled}");

            // char a = 'A';
            // Console.WriteLine($"char: {a}");

            // int q = 5;
            // int r = 6;
            // int s = -4;

            // Console.WriteLine($"q: {q}, r: {r}, s: {s}");

            // int multiply = s * r;
            // int divide = r / s;
            // int add = q + r;
            // int sub = r - s;
            // Console.WriteLine($"multiply: {multiply}, divide: {divide}, add: {add}, subtract: {sub}");

            // long n = 10203933874;
            // Console.WriteLine($"long: {n}");

            // float z = 3.5f;
            // double x = 7.8d;
            // decimal dec = 7.15m;
            // Console.WriteLine($"float: {z}, double: {x}, decimal: {dec}");

            // //copying values;
            // int a1 = 7;
            // int a2 = a1;
            // a1 = 4;
            // Console.WriteLine($"a1: {a1}, a2: {a2}");

            // //Nullable value types;
            // int? aa = null;
            // bool? bb = null;
            // Console.WriteLine($"int?: {aa}, bool?: {bb}");

            //implicit vs explicit
            // int age = 33;
            // float weight = 72.3f;
            // Console.WriteLine($"age: {age}, Weight: {weight}");

            // //implicit
            // long myAge = age;

            // //explicit;
            // int lessWeight = (int)weight;
            //                     //this is casting...

            // long bigNum = 1111111111111111111;
            // int smallNum = (int)bigNum;
            // Console.WriteLine(smallNum);
            // string luckyNum = "17";
            // int parsedLuckyNum = int.Parse(luckyNum);
            // double temp = double.Parse("5.1");
            

            //Date and Time;
            // DateTime dateOfBirth = new(1989, 11, 30);
            // Console.WriteLine(dateOfBirth.DayOfWeek);
            // int winningNum = 68;
            // if (winningNum == 68)
            // {
            //     Console.WriteLine("lucky lucky");
            // }
            // else
            // {
            //     Console.WriteLine("NOPE");
            // }

            // int myG = 34;
            // string myAge = myG == 34 ? "34" : "33";
            // Console.WriteLine(myAge);

            // int a = 1;
            // while (a <= 5)
            // {
            //     Console.WriteLine($"While: {a}");
            //     a++;
            // }

            // int b = 1;
            // do
            // {
            //     Console.WriteLine($"do-while: {b}");
            //     b++;
            // } while(b < 5);

            // for( int i = 0; i < 20; i++)
            // {
            //     if (i > 10)
            //     {
            //         Console.WriteLine($"I will end at 19: {i}");
            //     }
            // }

            // Console.WriteLine("Enter you birthday: ");

            // string birthday = Console.ReadLine();

            // if (birthday == "November 30th")
            // {
            //     Console.WriteLine("Happy birthday");
            // }
            // else
            // {
            //     Console.WriteLine("Not your birthday");
            // }
            int tries = 0;
            do 
            {
                Console.WriteLine("Would you like to try a math game? Y or N");

                string? v = Console.ReadLine();
                string answer = v;

                if(v == "Y" || v == "y")
                {
                    Console.WriteLine("do you want to add, subtract, divide or Multiply?");

                    string? z = Console.ReadLine();

                    // if(z == "Multiply" || z == "multiply")
                    // {
                    //    Console.WriteLine("Enter 2 numbers");
                    //    int a = Convert.ToInt32(Console.ReadLine());
                    //    int b = Convert.ToInt32(Console.ReadLine());
                    //    Console.WriteLine($"a was: {a} and b was: {b}. Multiplied they are: {a * b}!"); 
                    // }
                    // else if(z == "Add" || z == "add")
                    // {
                    //     Console.WriteLine("Enter 2 numbers");
                    //     int b1 = Convert.ToInt32(Console.ReadLine());
                    //     int a1 = Convert.ToInt32(Console.ReadLine());
                    //     Console.WriteLine($"a was: {a1} and b was: {b1}. Added they are: {a1 + b1}!");
                    // }
                    // else if(z == "Subtract" || z == "subtract")
                    // {
                    //     Console.WriteLine("Enter 2 numbers");
                    //     int a2 = Convert.ToInt32(Console.ReadLine());
                    //     int b2 = Convert.ToInt32(Console.ReadLine());
                    //     Console.WriteLine($"a was: {a2} and b was: {b2}. Subtracted they are: {a2 - b2}!");
                    // }
                    // else if (z == "Divide" || z == "divide")
                    // {
                    //     Console.WriteLine("Enter 2 numbers");
                    //     int a3 = Convert.ToInt32(Console.ReadLine());
                    //     int b3 = Convert.ToInt32(Console.ReadLine());
                    //     Console.WriteLine($"a was: {a3} and b was: {b3}. Divided they are: {a3 / b3}!"); 
                    // }
                    // else
                    // {
                    //    Console.WriteLine("Please explicitly spell out Add, Subtract, Divide or Multiply!"); 
                    // }

                    switch (z)
                    {
                        case "Multiply":
                        case "multiply":
                        Console.WriteLine("Enter 2 numbers");
                        int a = Convert.ToInt32(Console.ReadLine());
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"a was: {a} and b was: {b}. Multiplied they are: {a * b}!");
                        continue;

                        case "Add":
                        case "add":
                        Console.WriteLine("Enter 2 numbers");
                        int b1 = Convert.ToInt32(Console.ReadLine());
                        int a1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"a was: {a1} and b was: {b1}. Added they are: {a1 + b1}!");
                        continue;

                        case "Subtract":
                        case "subtract":
                        Console.WriteLine("Enter 2 numbers");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"a was: {a2} and b was: {b2}. Subtracted they are: {a2 - b2}!");
                        continue;

                        case "Divide":
                        case "divide":
                        Console.WriteLine("Enter 2 numbers");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"a was: {a3} and b was: {b3}. Divided they are: {a3 / b3}!");
                        continue;

                        default:
                        Console.WriteLine("Please explicitly spell out Add, Subtract, Divide or Multiply!");
                        break;

                    }
                    tries++;
                }
                else if (v == "N" || v == "n")
                {
                    Console.WriteLine("Understandable, Have a good day");
                    tries = 2;
                }
                else
                {
                    Console.WriteLine("Must answer Y or N");
                }
            } while (tries < 2);

  
            

            

            // string game = Console.ReadLine();
            // if (game == "Y")
            // {
            //     Console.WriteLine("lets go");
            // }
            // else
            // {
            //     Console.WriteLine("ending...");
            // }
        }   
    }
}
// value types
//do while loop
