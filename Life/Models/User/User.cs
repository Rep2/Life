using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class User : Model
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public DateTime ResourcesUpdatedAt { get; set; }


        public IList<UserResource> UserResources { get; set; }

        public IList<UserFactor> UserFactors { get; set; }

        public IList<ResearchedResearch> ResearchedResearchs { get; set; }


        public IList<Planet> Planets { get; set; }


        /// <summary>
        /// Checks if user has enaugh resource to build building
        /// </summary>
        /// <param name="buildingLevel">Building to be checked</param>
        /// <returns>True if user has enaughr resources, false otherwise</returns>
        public bool UserHasReseourceForBuild(BuildingLevel buildingLevel){

            var costs = buildingLevel.BuildingCosts;

            foreach (BuildingCost cost in costs)
            {
                //Check if user has enaugh resources
                var userResource = UserResources.Where(b => b.Resource.Id == cost.Resource.Id);
                if (userResource.Count() == 0 || userResource.First().Amount < cost.Value)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if user has enaugh resources to start research
        /// </summary>
        /// <param name="researchLevel">Research to be checked</param>
        /// <returns>True if user has enaughr resources, false otherwise</returns>
        public bool UserHasResourcesForResearch(ResearchLevel researchLevel)
        {
            var costs = researchLevel.ResearchCosts;

            foreach (ResearchCost cost in costs)
            {
                //Check if user has enaugh resources
                var userResource = UserResources.Where(b => b.Resource.Id == cost.Resource.Id);
                if (userResource.Count() == 0 || userResource.First().Amount < cost.Value)
                {
                    return false;
                }
            }

            return true;
        }

        public bool UserHasRequirmentsForResearch(ResearchLevel researchLevel)
        {
            if (ResearchedResearchs == null)
            {
                ResearchedResearchs = new List<ResearchedResearch>();
            }

            // Checks if lower level buildings exists
            if (researchLevel.Level != 1)
            {
                for (int i = 1; i < researchLevel.Level; i++)
                {
                    var lowerLvlResesearch = ResearchedResearchs.Where(
                        b => b.ResearchLevel.Research.Id == researchLevel.Research.Id
                        && b.ResearchLevel.Level == i);

                    if (lowerLvlResesearch.Count() == 0)
                    {
                        return false;
                    }
                }
            }

            // Checks if same level building exists
            var sameLvlResearch = ResearchedResearchs.Where(
                        b => b.ResearchLevel.Research.Id == researchLevel.Research.Id
                        && b.ResearchLevel.Level == researchLevel.Level);

            if (sameLvlResearch.Count() != 0)
            {
                return false;
            }

            return true;
        }

    }
}
