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

        /// <summary>
        /// Adds costs to building level automaticaly creating double link
        /// </summary>
        /// <param name="costs">Costs to be added</param>
        public void AddBuildingLevelCosts(List<BuildingCost> costs)
        {
            if (this.BuildingCosts == null)
            {
                this.BuildingCosts = new List<BuildingCost>();
            }

            foreach (BuildingCost cost in costs)
            {
                cost.BuildingLevel = this;
                this.BuildingCosts.Add(cost);
            }

        }

        /// <summary>
        /// Adds factor modifiers to building level automaticaly creating double link
        /// </summary>
        /// <param name="costs">Factor modifiers to be added</param>
        public void AddBuildingLevelFactorModifiers(List<BuildingFactorModifier> factors)
        {
            if (this.BuildingFactorModifiers == null)
            {
                this.BuildingFactorModifiers = new List<BuildingFactorModifier>();
            }

            foreach (BuildingFactorModifier factor in factors)
            {
                factor.BuildingLevel = this;
                this.BuildingFactorModifiers.Add(factor);
            }

        }
    }
}
