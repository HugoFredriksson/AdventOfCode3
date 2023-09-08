<<<<<<< HEAD
﻿string[] sacks = File.ReadAllLines("input.txt");
int total = 0;



for (int i = 0; i < sacks.Length; i += 3) 
{
    string first = sacks[i];
    string second = sacks[i+1];
    string third = sacks[i+2];
    var intersection = first.Intersect(second).Intersect(third);
    foreach (var c in intersection)
    {
        if (char.IsUpper(c))
        {
            total += c - 38;
        }
        else
        {
            total += c - 96;
        }
        

    }
}
int counter = 0;
string[] elfs = new string[3];
foreach (var c in sacks)
{
    elfs[counter] = c;
    counter++;
    if(counter == 2)
    {
        counter = 0;

    }
}
    Console.WriteLine(total);
=======
﻿var lines = File.ReadAllLines("input.txt");

int total = lines.Select(line =>
{
    var first = line.Take(line.Length / 2);
    var second = line.Skip(line.Length / 2);

    return first.Intersect(second).Select(c => Char.IsUpper(c) ? c - 38 : c - 96).Sum();

}).Sum();
Console.WriteLine(total);

int del2Total = lines.Chunk(3).Select(ls =>
{
    var first = ls[0];
    var second = ls[1];
    var third = ls[2];

    return first.Intersect(second).Intersect(third).Select(c => Char.IsUpper(c) ? c - 38 : c - 96).Sum();

}).Sum();
Console.WriteLine(del2Total);
>>>>>>> e50916d1aade86fce59b815ed12b8e6899d52563
