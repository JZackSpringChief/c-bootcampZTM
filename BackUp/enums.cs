// enum Days
// {
//     Sunday,
//     Monday,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday,
//     Saturday
// }
// class Enums
// {
//     static void Main()
//     {
//         Days today = Days.Wednesday;
//         Console.WriteLine(today);

//     }
// }
// var temperature = new Temperature(TempuratureUnit.Celcius, 10);
// enum TempuratureUnit
// {
//     Celcius,
//     Fahrenheit,
//     Kelvin
// }

// class Temperature
// {
//     public Temperature(TempuratureUnit unit, decimal value)
//     {
//         Unit = unit;
//         Value = value;
//     }
//     public TempuratureUnit Unit { get; set; }
//     public decimal Value { get; set; }
//     public decimal ValueInCelcius
//     {
//         get
//         {
//             if (Unit == TempuratureUnit.Celcius)
//             {
//                 return Value;
//             }
//             if (Unit == TempuratureUnit.Fahrenheit)
//             {
//                 return (Value - 32) * 5 / 9;
//             }
//             if (Unit == TempuratureUnit.Kelvin)
//             {
//                 return Value - 273.5m;
//             }
//             return 0;
//         }
//     }
// }