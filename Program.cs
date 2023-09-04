string[] sacks = File.ReadAllLines("input.txt");
int total = 0;
foreach (string sack in sacks)
{
    int m = sack.Length / 2;
    string comp1 = sack.Substring(0, m);
    string comp2 = sack.Substring(m);
    var intersection = comp1.Intersect(comp2);
    foreach(var i in intersection)
    {
        if (char.IsUpper(i)) {
            total += i - 38;
        } else
        {
            total += i - 96; 
        }
       
    }

}

Console.WriteLine(total);
