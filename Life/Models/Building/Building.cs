using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class Building : Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<BuildingLevel> BuildingLevels { get; set; }

        /// <summary>
        /// Adds building levels to building
        /// </summary>
        /// <param name="buildingLevels">Building levels to be added</param>
        public void AddBuildingLevels(List<BuildingLevel> buildingLevels)
        {
            if (this.BuildingLevels == null)
            {
                this.BuildingLevels = new List<BuildingLevel>();
            }

            foreach (BuildingLevel buildingLevel in buildingLevels){
                buildingLevel.Building = this;
                this.BuildingLevels.Add(buildingLevel);
            }
        }
    }
}
