// var Hero = new Human("Zack", "Lord", 10);
// Console.WriteLine(Hero.IsPhysical());
// public static class HumanExtentions
// {
//     public static string WeaponAndAttackPower(this Human Hero)
//     {
//         return $"{Hero.SpecialMove()} adds +{Hero.addAttack()}";
//     }
// }
// public static class PhysicalUnitExtention
// {
//     public static bool IsPhysical(this IPhysicalUnit physicalUnit)
//     {
//         return physicalUnit.IsPhysical == "true";
//     }
// }
// public interface IPhysicalUnit
// {
//     int addAttack();
//     string IsPhysical { get; }
// }
// public class Human : IPhysicalUnit
// {
//     public int addAttack()
//     {
//         return Attack + 5;
//     }

//     public string WeaponType()
//     {
//         return "Sword";
//     }
//     public Human(string name, string jobClass, int attack)
//     {
//         Name = name;
//         JobClass = jobClass;
//         Attack = attack;
//     }
//     public string Name { get; set; }
//     public string JobClass { get; set; }
//     public int Attack { get; set; }
//     public string IsPhysical
//     {
//         get
//         {
//             return "true";
//         }
//     }
//     public string SpecialMove()
//     {
//         return "Meggido Flame";
//     }
// }