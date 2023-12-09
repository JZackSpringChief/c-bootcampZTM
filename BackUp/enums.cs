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
//Switch Expression
// var temperature = new Temperature(TempuratureUnit.Celcius, 112.6m);
// Console.WriteLine($"Tempurature: {temperature.ValueInCelcius.ToString("0.0")}C");
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
//             return Unit switch
//             {
//                 TempuratureUnit.Celcius when Value > 100 => Math.Round(Value, 0), //guard clause
//                 TempuratureUnit.Celcius => Value,
//                 TempuratureUnit.Fahrenheit => (Value - 32) * 5 / 9,
//                 TempuratureUnit.Kelvin => Value - 273.5m,
//                 _ => 0
//             };
//         }
//     }
// }