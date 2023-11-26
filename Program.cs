//optional params
Person p1 = new("Zack", age: 34, favColor: "red");
Person p2 = new("Kyle", age: 31, luckyNumber: 9);
Person p3 = new("Daniel", age: 35);
Person p4 = new("Dad", age: 61, favColor: "Blue", luckyNumber: 62);

public class Person
{
    public Person(string name, int age, int luckyNumber = 7, string favColor = "purple")
    {
        Name = name;
        Age = age;
        LuckyNumber = luckyNumber;
        FavColor = favColor;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public int LuckyNumber { get; set; }
    public string FavColor { get; set; }
}