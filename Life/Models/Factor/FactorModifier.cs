using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public abstract class FactorModifier
    {

        public virtual int Id { get; set; }

        public virtual double Value { get; set; }

        public virtual string Type { get; set; }


        public virtual Factor Factor { get; set; }
    }

    public class BuildingFactorModifier : FactorModifier
    {
        public virtual BuildingLevel BuildingLevel { get; set; }
    }

    public class ResearchFactorModifier : FactorModifier
    {
        public virtual ResearchLevel ResearchLevel { get; set; }
    }
}
