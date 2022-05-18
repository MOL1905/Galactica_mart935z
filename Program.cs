using Galactica_mart935z;

Data data = new();

if (data.Sun.PlanetList == null) return;

Console.WriteLine("Planets");
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name} Type {p.Type} Distance to Sun Pos {p.Distance()} {p.ToString()}");
    if (p.MoonList != null)
    { 
        Console.WriteLine("***Moons***");
    foreach (Moon m in p.MoonList)
        {
            Console.WriteLine($"\t{m.Name}\n");
        }
    }
}