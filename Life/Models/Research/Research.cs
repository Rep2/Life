using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class Research : Model
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<ResearchLevel> ResearchLevels { get; set; }

    }
}
        /// <summary>
        /// Adds research levels to research automaticaly creating double link
        /// </summary>
        /// <param name="levels">Levels to be added</param>
        public void AddResearchLevels(List<ResearchLevel> levels)
        {
            if (this.ResearchLevels == null)
            {
                this.ResearchLevels = new List<ResearchLevel>();
            }

            foreach (ResearchLevel level in levels)
            {
                level.Research = this;
                this.ResearchLevels.Add(level);
            }

        }
    }
}
