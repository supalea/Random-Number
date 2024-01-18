
Random r = new Random();
Dictionary <int, int> dict = new Dictionary <int, int>();
int x;

for (int i = 0; i < 10; i++)
{
     x = r.Next(0, 10);
    Console.WriteLine($"{i} | {x}");

    if (dict.ContainsKey(x))
    {
        dict[x]++;
    }
    else
    {
        dict[x] = 1;
    }
}

foreach(var zahl in dict)
{
    Console.WriteLine("Zahl: {0}, Anzahl: {1}", zahl.Key, zahl.Value);
}
    



