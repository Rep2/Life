using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class Planet : Model
    {

        public int Id { get; set; }

        public int Size { get; set; }

        public int Temperature { get; set; }

        public Location Location { get; set; }

        public CurrentlyBuilding CurrentlyBuilding { get; set; }


        public User User { get; set; }

        public IList<BuiltBuilding> BuiltBuildings { get; set; }

    }

    public class Location
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
    }

    public class CurrentlyBuilding
    {

        public DateTime Start { get; set; }

        public BuildingLevel BuildingLevel { get; set; }

    }
}
