namespace Galactica_mart935z
{
    internal class Data
    {
        public Star Sun = new Star();

        //Add planets and attributes to planetList
        List<Planet> planets = new List<Planet>()
        {
            new Planet(){Name = "Mercury",Diameter = 4879,RevolutionPeriod = 88,RotationPeriod = 1407,Id = 0,Type = PlanetType.Terrestial,
            Pos = new SpaceObjects.Position{X = 0, Y = 1} },
            new Planet(){Name = "Venus",Diameter = 12104,RevolutionPeriod = 225,RotationPeriod = -5832,Id = 1,Type = PlanetType.Terrestial,
            Pos = new SpaceObjects.Position{X = 3, Y = 4} },
            earth;
            new Planet(){Name = "Mars",Diameter = 6792,RevolutionPeriod = 687,RotationPeriod = 25,Id = 3,Type = PlanetType.Terrestial,
            Pos = new SpaceObjects.Position{X = -8, Y = -12} },
            new Planet(){Name = "Jupiter",Diameter = 142984,RevolutionPeriod = 4331,RotationPeriod = 10,Id = 4,Type = PlanetType.Gas_Giant,
            Pos = new SpaceObjects.Position{X = 4, Y = -20} },
            new Planet(){Name = "Saturn",Diameter = 120536,RevolutionPeriod = 10747,RotationPeriod = 11,Id = 5,Type = PlanetType.Gas_Giant,
            Pos = new SpaceObjects.Position{X = 32, Y = -10} },
            new Planet(){Name = "Uranus",Diameter = 51118,RevolutionPeriod = 30589,RotationPeriod = -17,Id = 6,Type = PlanetType.Gas_Giant,
            Pos = new SpaceObjects.Position{X = 38, Y = 58} },
            new Planet(){Name = "Neptune",Diameter = 49528,RevolutionPeriod = 59800,RotationPeriod = 16,Id = 7,Type = PlanetType.Gas_Giant,
            Pos = new SpaceObjects.Position{X = -75, Y = -82} },
            new Planet(){Name = "Pluto",Diameter = 2376,RevolutionPeriod = 90560,RotationPeriod = 153,Id = 8,Type = PlanetType.Dwarf,
            Pos = new SpaceObjects.Position{X = 150, Y = 99} }
        };

        public Data()
        {
            Sun.PlanetList = planets;
        }

        void AddPlanets()
        {
            Planet earth = new Planet()new Planet()
            {
                Name = "Earth",
                Diameter = 12756,
                RevolutionPeriod = 365,
                RotationPeriod = 24,
                Id = 2,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObjects.Position { X = 6, Y = -8 } MoonList = new() { new Moon { Name = "Luna", Orbiting = } 
                },
        }
    }
}
