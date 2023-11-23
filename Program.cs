//generic dictionaary;
var grades = new Dictionary<char, int>
{
    { 'A', 100 },
    { 'B', 85}
};

grades.Add('C', 70);
grades['D'] = 65;
grades['E'] = 50;
grades['F'] = 49;

Console.WriteLine(grades['E']);

foreach (var grade in grades)
{
    Console.WriteLine($"{grade.Key}: {grade.Value}");

}
Console.WriteLine(grades.ContainsKey('F'));