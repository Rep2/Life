using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Repositories;
using Life.Models;

namespace Life.Factory
{
    class BuildingFactory
    {

        public static void Init()
        {
            var buildingRepository = new Repository<Building>();

            if (buildingRepository.Get().Count == 0)
            {
                buildingRepository.Create(
                    MockData()
                );
            }
        }

        public static List<Building> MockData(){
            return new List<Building>(){
                        CreateMetalMine(),
                        CreateCarbonMine(),
                        CreateFuleDest(),
                        CreateShipyard(),
                        CreateResearchLab()
                    };
        }


        /// <summary>
        /// Creates metal mine building with all levels, costs and modigiers
        /// </summary>
        /// <returns>MEtal mine</returns>
        private static Building CreateMetalMine()
        {
            var metalMine = 
                new Building()
                        {
                            Name = "Metal mine",
                            Description = "Mines metal ore and refines it"
                        };

            var buildingLevels = new List<BuildingLevel>(){
                new BuildingLevel()
                {
                    Level = 1,
                    BuildDuration = 100,
                },
                new BuildingLevel()
                {
                    Level = 2,
                    BuildDuration = 300
                },
                new BuildingLevel(){ 
                    Level = 3,
                    BuildDuration = 900
                },
                new BuildingLevel()
                {
                    Level = 4,
                    BuildDuration = 1600
                },
                new BuildingLevel()
                {
                    Level = 5,
                    BuildDuration = 2400
                },
                new BuildingLevel()
                {
                    Level = 6,
                    BuildDuration = 4700
                }
            };

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var factorRepository = new Repository<Factor>();
            var metalFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();

            buildingLevels.ElementAt(0).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 100
                        }
                    }
            );


            buildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 30
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 600
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 150
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 80
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 1900
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 320
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 210
                        }
                    }
            );


            buildingLevels.ElementAt(3).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 3400
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 600
                        }
                    }
            );

            buildingLevels.ElementAt(3).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 340
                        }
                    }
            );


            buildingLevels.ElementAt(4).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 6200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 920
                        }
                    }
            );

            buildingLevels.ElementAt(4).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 480
                        }
                    }
            );


            buildingLevels.ElementAt(5).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 9000
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 1100
                        }
                    }
            );

            buildingLevels.ElementAt(5).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = metalFactor,
                            Value = 780
                        }
                    }
            );
            
            metalMine.AddBuildingLevels(buildingLevels);

            return metalMine;
        }


        /// <summary>
        /// Creates carbon mine building with all levels, costs and modigiers
        /// </summary>
        /// <returns>Carbon extractor</returns>
        private static Building CreateCarbonMine()
        {
            var carbonExtr =
                new Building()
                {
                    Name = "Carbon extractor",
                    Description = "Extracts pure carbon from planets soil"
                };

            var buildingLevels = new List<BuildingLevel>(){
                    new BuildingLevel()
                    {
                        Level = 1,
                        BuildDuration = 150
                    },
                    new BuildingLevel()
                    {
                        Level = 2,
                        BuildDuration = 380
                    },
                    new BuildingLevel()
                    {
                        Level = 3,
                        BuildDuration = 1100
                    },
                    new BuildingLevel()
                    {
                        Level = 4,
                        BuildDuration = 1900
                    },
                    new BuildingLevel()
                    {
                        Level = 5,
                        BuildDuration = 320
                    }
                };

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var factorRepository = new Repository<Factor>();
            var carbonFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();

            buildingLevels.ElementAt(0).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 400
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 160
                        }
                    }
            );

            buildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = carbonFactor,
                            Value = 20
                        }
                    }
            );


            buildingLevels.ElementAt(1).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 900
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 340
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = carbonFactor,
                            Value = 90
                        }
                    }
            );


            buildingLevels.ElementAt(2).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 1900
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 660
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = carbonFactor,
                            Value = 190
                        }
                    }
            );

            buildingLevels.ElementAt(3).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 3200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 890
                        }
                    }
            );

            buildingLevels.ElementAt(3).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = carbonFactor,
                            Value = 320
                        }
                    }
            );


            buildingLevels.ElementAt(4).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 6400
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 1400
                        }
                    }
            );

            buildingLevels.ElementAt(4).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = carbonFactor,
                            Value = 610
                        }
                    }
            );

            carbonExtr.AddBuildingLevels(buildingLevels);

            return carbonExtr;
        }

        /// <summary>
        /// Creates fule destilery building with all levels, costs and modigiers
        /// </summary>
        /// <returns>Fule destilery building</returns>
        public static Building CreateFuleDest()
        {
            var fuleDest = new Building()
                {
                    Name = "Fule destilery",
                    Description = "Extracts basic alkanes from planets harsh environment"
                };

            var buildingLevels = new List<BuildingLevel>(){
                    new BuildingLevel()
                    {
                        Level = 1,
                        BuildDuration = 250
                    },
                    new BuildingLevel()
                    {
                        Level = 2,
                        BuildDuration = 450
                    },
                    new BuildingLevel()
                    {
                        Level = 3,
                        BuildDuration = 1100
                    }
                };

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var factorRepository = new Repository<Factor>();
            var fuleFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();

            buildingLevels.ElementAt(0).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 500
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 230
                        }
                    }
            );

            buildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = fuleFactor,
                            Value = 25
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 1100
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 410
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = fuleFactor,
                            Value = 60
                        }
                    }
            );


            buildingLevels.ElementAt(2).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 2400
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 1000
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = fuleFactor,
                            Value = 155
                        }
                    }
            );

            fuleDest.AddBuildingLevels(buildingLevels);

            return fuleDest;
        }

        /// <summary>
        /// Creates shipyard building with all levels, costs and modigiers
        /// </summary>
        /// <returns>Shipyard building</returns>
        private static Building CreateShipyard(){

            var shipyard = new Building()
                {
                    Name = "Shipyard",
                    Description = "Allows production of space ships"
                };

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();
            var fule = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();


            var factorRepository = new Repository<Factor>();
            var shipBuildFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Ship build speed" } }).First();

            var buildingLevels = new List<BuildingLevel>(){
                    new BuildingLevel()
                    {
                        Level = 1,
                        BuildDuration = 850
                    },
                    new BuildingLevel()
                    {
                        Level = 2,
                        BuildDuration = 1700
                    },
                    new BuildingLevel()
                    {
                        Level = 3,
                        BuildDuration = 4200
                    }
                };

            buildingLevels.ElementAt(0).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 1200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 3000
                        },
                        new BuildingCost(){
                            Resource = fule,
                            Value = 1000
                        }
                    }
            );

            buildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = shipBuildFactor,
                            Value = 25
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 3200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 8000
                        },
                        new BuildingCost(){
                            Resource = fule,
                            Value = 3200
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = shipBuildFactor,
                            Value = 55
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 6200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 14000
                        },
                        new BuildingCost(){
                            Resource = fule,
                            Value = 7200
                        }
                    }
            );

            buildingLevels.ElementAt(2).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = shipBuildFactor,
                            Value = 85
                        }
                    }
            );


            return shipyard;
        }

        /// <summary>
        /// Creates research lab building with all levels, costs and modigiers
        /// </summary>
        /// <returns>Research lab building</returns>
        public static Building CreateResearchLab()
        {
            var researchLab = new Building()
                {
                    Name = "Research lab",
                    Description = "Allows reasearch of different types of researches"
                };

            var buildingLevels = new List<BuildingLevel>(){
                    new BuildingLevel()
                    {
                        Level = 1,
                        BuildDuration = 1000
                    },
                    new BuildingLevel()
                    {
                        Level = 2,
                        BuildDuration = 1900
                    }
                };

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();
            var fule = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();


            var factorRepository = new Repository<Factor>();
            var researchFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Research speed" } }).First();

            buildingLevels.ElementAt(0).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 1200
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 6000
                        },
                        new BuildingCost(){
                            Resource = fule,
                            Value = 2200
                        }
                    }
            );

            buildingLevels.ElementAt(0).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = researchFactor,
                            Value = 10
                        }
                    }
            );


            buildingLevels.ElementAt(1).AddBuildingLevelCosts(
                new List<BuildingCost>()
                    {
                        new BuildingCost(){
                            Resource = metal,
                            Value = 3000
                        },
                        new BuildingCost(){
                            Resource = carbon,
                            Value = 12000
                        },
                        new BuildingCost(){
                            Resource = fule,
                            Value = 4200
                        }
                    }
            );

            buildingLevels.ElementAt(1).AddBuildingLevelFactorModifiers(
                new List<BuildingFactorModifier>()
                    {
                        new BuildingFactorModifier(){
                            Factor = researchFactor,
                            Value = 40
                        }
                    }
            );

            return researchLab;
        }
    }
}
