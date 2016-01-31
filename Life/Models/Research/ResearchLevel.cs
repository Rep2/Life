using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class ResearchLevel : Model
    {

        public int Id { get; set; }

        public int Level { get; set; }

        public double Duration { get; set; }

        public int ResearchLabLevel { get; set; }

        public Research Research { get; set; }

        public IList<ResearchCost> ResearchCosts { get; set; }

        public ResearchLevel ResearchRequirment { get; set; }

        public IList<ResearchFactorModifier> ResearchFactorModifiers { get; set; }
    }
}
