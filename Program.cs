var Hero = new Human("Zack", "Lord", 10);
Console.WriteLine(Hero.WeaponAndAttackPower());


public interface IPhysicalUnit
{
    string WeaponType();
    int addAttack();
}
public class Human : IPhysicalUnit
{
    public int addAttack()
    {
        return Attack + 5;
    }

    public string WeaponType()
    {
        return "Sword";
    }


    public Human(string name, string jobClass, int attack)
    {
        Name = name;
        JobClass = jobClass;
        Attack = attack;
    }
    public string Name { get; set; }
    public string JobClass { get; set; }
    public int Attack { get; set; }
    public string SpecialMove()
    {
        return "Meggido Flame";
    }
}
