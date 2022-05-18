using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica_mart935z
{
    //Make class inheritable but restricted (abstract),
    //so not to instatiate/create objects
    internal abstract class SpaceObjects
    {
        //Add properties
        public int? Id { get; set; }
        public string? Name { get; set; }

        public virtual Position? Pos { get; set; }

        //Create nested class Position consisting of two coordinates: X, Y
        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        //position overrides tostring and returns values: (X, Y)
        public override string ToString()
        {
            if (Pos != null)
                return $"({Pos.X},{Pos.Y})";
            else return string.Empty;
        }
    }
}
