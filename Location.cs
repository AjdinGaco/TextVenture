using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextVenture
{
    class Location
    {
        List<Location> connectedLocations = new List<Location>();
        List<Entity> entities = new List<Entity>();
    }
}
