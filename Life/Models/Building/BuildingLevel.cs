using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class BuildingLevel : Model
    {
        public int Id { get; set; }

        public int Level { get; set; }

        public double BuildDuration { get; set; }

        public Building Building { get; set; }

        public IList<BuildingCost> BuildingCosts { get; set; }

        public IList<BuildingFactorModifier> BuildingFactorModifiers { get; set; }
    }
}
