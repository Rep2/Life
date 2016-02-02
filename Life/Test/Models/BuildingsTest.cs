using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Life.Models;
using Life.Factory;

namespace Life.Test.Models
{
    public class BuildingsTest
    {

        [Fact]
        public void BuildingCreation()
        {
            var metalMine = CreateMetalMine();

            Assert.Equal(metalMine.BuildingLevels.Count, 2);
            Assert.Equal(metalMine.BuildingLevels.ElementAt(0).BuildDuration, 1);
        }

        [Fact]
        public void BuildingCost()
        {

             var metalMine = 
                new Building()
                        {
                            Name = "Metal mine",
                            Description = "Mines metal ore and refines it",
                            BuildingLevels = new List<BuildingLevel>(){
                                new BuildingLevel()
                                {
                                    Level = 1,
                                    BuildDuration = 100,
                                }
                            }
                        };


             metalMine.BuildingLevels.ElementAt(0).AddBuildingLevelCosts(
                 new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = new Resource(){
                                Name = "Metal",
                                Description = "asdasd",
                                InitialValue = 123
                            },
                            Value = 600
                        }
                    }
                );

            Assert.Equal(metalMine.BuildingLevels.ElementAt(0).BuildingCosts.Count, 1);
            Assert.Equal(metalMine.BuildingLevels.ElementAt(0)
                .BuildingCosts.ElementAt(0).Resource.Name, "Metal");

        }

        [Fact]
        public void BuildingModifiers()
        {

            var metalMine =
               new Building()
               {
                   Name = "Metal mine",
                   Description = "Mines metal ore and refines it",
                   BuildingLevels = new List<BuildingLevel>(){
                                new BuildingLevel()
                                {
                                    Level = 1,
                                    BuildDuration = 100,
                                }
                            }
               };


            metalMine.BuildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = new Factor(){
                                Name = "Research speed",
                                Description = "sdas",
                                 InitialValue = 20
                            },
                            Value = 20
                        },
                        new BuildingFactorModifier(){
                            Factor = new Factor(){
                                Name = "Build speed",
                                Description = "sdas",
                                 InitialValue = 10
                            },
                            Value = 45
                        }
                    }
               );

            Assert.Equal(metalMine.BuildingLevels.ElementAt(0).BuildingFactorModifiers.Count, 2);
            Assert.Equal(metalMine.BuildingLevels.ElementAt(0)
                .BuildingFactorModifiers.ElementAt(0).Factor.Name, "Research speed");
            Assert.Equal(metalMine.BuildingLevels.ElementAt(0)
                .BuildingFactorModifiers.ElementAt(1).Value, 45);
        }

        public Building CreateMetalMine()
        {
            var metalMine =
                    new Building()
                    {
                        Name = "Metal mine",
                        Description = "Mines metal ore and refines it"
                    };

            Assert.Equal(metalMine.Name, "Metal mine");

            var buildingLevels = new List<BuildingLevel>(){
                new BuildingLevel()
                {
                    Level = 1,
                    BuildDuration = 1,
                },
                new BuildingLevel()
                {
                    Level = 2,
                    BuildDuration = 3
                }
            };

            metalMine.AddBuildingLevels(buildingLevels);

            return metalMine;
        }

    }

}
