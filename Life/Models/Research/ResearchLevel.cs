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

        /// <summary>
        /// Adds research levels costs to research level automaticaly creating double link
        /// </summary>
        /// <param name="costs">Costs to be added</param>
        public void AddResearchLevelsCosts(List<ResearchCost> costs)
        {
            if (this.ResearchCosts == null)
            {
                this.ResearchCosts = new List<ResearchCost>();
            }

            foreach (ResearchCost cost in costs)
            {
                cost.ResearchLevel = this;
                this.ResearchCosts.Add(cost);
            }

        }

        /// <summary>
        /// Adds research level modifers to research level automaticaly creating double link
        /// </summary>
        /// <param name="modifers">Levels to be added</param>
        public void AddResearchLevelModifiers(List<ResearchFactorModifier> modifiers)
        {
            if (this.ResearchFactorModifiers == null)
            {
                this.ResearchFactorModifiers = new List<ResearchFactorModifier>();
            }

            foreach (ResearchFactorModifier modifier in modifiers)
            {
                modifier.ResearchLevel = this;
                this.ResearchFactorModifiers.Add(modifier);
            }

        }
    }
}
