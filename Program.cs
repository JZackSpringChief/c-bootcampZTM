﻿var Hero = new Human("Zack", "Lord");
Console.WriteLine(Hero.WeaponOfChoice());

public interface IPhysicalUnit
{
    string WeaponTypel();
    int addAttack();
}
public class Human : IPhysicalUnit
{
    public int addAttack()
    {
        return 5;
    }

    public string WeaponTypel()
    {
        return "Sword";
    }


    public Human(string name, string jobClass)
    {
        Name = name;
        JobClass = jobClass;
    }
    public string Name { get; set; }
    public string JobClass { get; set; }


    public string WeaponOfChoice()
    {
        Console.WriteLine("Choose 'a' for Sword or 'b' for Axe");
        string? a = Console.ReadLine();
        a = a?.ToLower();

        if (a == "a")
        {
            return "Take this Excalabur";
        }
        else if (a == "b")
        {
            return "Take this Armadeus";
        }
        else
        {
            return "please choose 'a' or 'b'";
        }
    }
}
