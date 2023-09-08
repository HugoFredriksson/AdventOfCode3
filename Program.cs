string[] sacks = File.ReadAllLines("input.txt");
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