using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class BuiltBuilding
    {

        public int Id { get; set; }

        public Planet Planet { get; set; }

        public BuildingLevel BuildingLevel { get; set; }
    }
}
