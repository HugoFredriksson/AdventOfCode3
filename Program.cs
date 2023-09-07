var lines = File.ReadAllLines("input.txt");

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