using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life.Models
{
    public class Planet : Model
    {

        public int Id { get; set; }

        public int Size { get; set; }

        public int Temperature { get; set; }

        public Location Location { get; set; }

        public CurrentlyBuilding CurrentlyBuilding { get; set; }

        public CurrentlyResearching CurrentlyResearching { get; set; }


        public User User { get; set; }

        public IList<BuiltBuilding> BuiltBuildings { get; set; }


        public bool BuildBuilding(BuildingLevel buildingLevel)
        {
            if (User == null)
            {
                return false;
            }
            else
            {
                if (!User.UserHasReseourceForBuild(buildingLevel))
                {
                    return false;
                }
            }

            if (!StartBuildingBuilding(buildingLevel))
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Start build of building level if all requirments are met
        /// </summary>
        /// <param name="buildingLevel">Building level to be built</param>
        /// <returns>True if building started, false otherwise</returns>
        public bool StartBuildingBuilding(BuildingLevel buildingLevel)
        {
            RefreshBuildingBuildState();

            if (CurrentlyBuilding != null)
            {
                return false;
            }

            if (!PlanetHasAllRequirmentsForBuilding(buildingLevel))
            {
                return false;
            }

            CurrentlyBuilding = new CurrentlyBuilding()
            {
                BuildingLevel = buildingLevel,
                BuildingStart = DateTime.Now
            };

            return true;
        }


        /// <summary>
        /// Refreshes currently building building
        /// If building is build will remove from building state and add to built buildings
        /// </summary>
        public void RefreshBuildingBuildState()
        {
            if (CurrentlyBuilding != null)
            {
                var buildingLevel = CurrentlyBuilding.BuildingLevel;

                if (CurrentlyBuilding.BuildingStart.Add(
                    new TimeSpan(0, 0, (int)buildingLevel.BuildDuration))
                    < DateTime.Now)
                {
                    AddBuilding(buildingLevel);
                    CurrentlyBuilding = null;
                }
            }
        }


        /// <summary>
        /// Adds built building with level to planet while checking all requirments
        /// </summary>
        /// <param name="buildingLevel">Building level to be added</param>
        /// <returns>True if building added, false otherwise</returns>
        public bool AddBuilding(BuildingLevel buildingLevel)
        {
            if (!PlanetHasAllRequirmentsForBuilding(buildingLevel)){
                return false;            
            }
            
            // Adds the building
            BuiltBuildings.Add(
                new BuiltBuilding()
                {
                    BuildingLevel = buildingLevel,
                    Planet = this
                }
            );

            return true;
        }

        /// <summary>
        /// Checks if all previous levels are built and current level not built
        /// </summary>
        /// <param name="buildingLevel">Building that is checked</param>
        /// <returns>True if building can be built</returns>
        public bool PlanetHasAllRequirmentsForBuilding(BuildingLevel buildingLevel){
            
            if (BuiltBuildings == null)
            {
                BuiltBuildings = new List<BuiltBuilding>();
            }

            // Checks if lower level buildings exists
            if (buildingLevel.Level != 1)
            {
                for (int i = 1; i < buildingLevel.Level; i++)
                {
                    var lowerLvlBuilding = BuiltBuildings.Where(
                        b => b.BuildingLevel.Building.Id == buildingLevel.Building.Id
                        && b.BuildingLevel.Level == i);

                    if (lowerLvlBuilding.Count() == 0)
                    {
                        return false;
                    }
                }
            }

            // Checks if same level building exists
            var sameLvlBuilding = BuiltBuildings.Where(
                        b => b.BuildingLevel.Building.Id == buildingLevel.Building.Id
                        && b.BuildingLevel.Level == buildingLevel.Level);

            if (sameLvlBuilding.Count() != 0)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Stops building
        /// </summary>
        /// <returns>True if building was stoped, false if build already compelted</returns>
        public bool StopBuilding()
        {
            if (CurrentlyBuilding == null)
            {
                return true;
            }

            RefreshBuildingBuildState();

            if (CurrentlyBuilding == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public bool StartResearch(ResearchLevel researchLevel)
        {
            if (User == null)
            {
                return false;
            }
            else
            {
                if (!User.UserHasResourcesForResearch(researchLevel))
                {
                    return false;
                }
            }

            if (!User.UserHasRequirmentsForResearch(researchLevel))
            {
                return false;
            }

            CurrentlyResearching = new CurrentlyResearching()
            {
                ResearchLevel = researchLevel,
                ResearchStart = DateTime.Now
            };

            return true;
        }

        public void AddResearch(ResearchLevel researchLevel)
        {

        }

        /// <summary>
        /// Refreshes current research
        /// </summary>
        public void RefreshResearchState()
        {
            if (CurrentlyResearching != null)
            {
                var researchLevel = CurrentlyResearching.ResearchLevel;

                if (CurrentlyResearching.ResearchStart.Add(
                    new TimeSpan(0, 0, (int)researchLevel.Duration))
                    < DateTime.Now)
                {
                    AddResearch(researchLevel);
                    CurrentlyResearching = null;
                }
            }
        }


    }

    public class Location
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }
    }

    public class CurrentlyBuilding
    {

        public DateTime BuildingStart { get; set; }

        public BuildingLevel BuildingLevel { get; set; }

    }

    public class CurrentlyResearching
    {
        public DateTime ResearchStart { get; set; }

        public ResearchLevel ResearchLevel { get; set; }
    }
}
