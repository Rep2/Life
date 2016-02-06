using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public abstract class ResourceCost
    {

        public virtual int Id { get; set; }

        public virtual double Value { get; set; }

        public virtual string Type { get; set; }


        public virtual Resource Resource { get; set; }
    }

    public class BuildingCost : ResourceCost
    {
        public virtual BuildingLevel BuildingLevel { get; set; }
    }

    public class ResearchCost : ResourceCost
    {
        public virtual ResearchLevel ResearchLevel { get; set; }
    }

}
