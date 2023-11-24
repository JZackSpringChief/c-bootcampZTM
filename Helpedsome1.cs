// namespace HouseClassEx
// {

//     internal class Program
//     {
//         static House house1 = new House(1996, 2400);

//         static void Main(string[] args)
//         {
//             Console.WriteLine("Please enter the year your house was built: ");
//             house1.YearBuilt = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Please enter the sq. ft. of your house: ");
//             house1.SqftSize = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine($"Your home was built in {house1.YearBuilt}, and is {house1.SqftSize} sq. ft.");

//             Console.WriteLine($"Your house is {house1.CanBeSold()} to sell on the market.");
//         }
//     }

//     class House
//     {
//         public House(int yearBuilt, int sqftSize)
//         {
//             YearBuilt = yearBuilt;
//             SqftSize = sqftSize;
//         }

//         public int YearBuilt { get; set; }

//         public int SqftSize { get; set; }

//         private int HowOld()
//         {
//             int currentYear = DateTime.Now.Year;

//             return currentYear - YearBuilt;
//         }

//         public string CanBeSold()
//         {
//             if (HowOld() > 15)
//             {
//                 return "eligible";
//             }

//             return "ineligible";
//         }
//     }
// }