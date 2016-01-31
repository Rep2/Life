using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.Repositories;

namespace Life.Factory
{
    class BuildingLevelFactory
    {

        public static void Init()
        {

            var buildingLvlRepository = new Repository<BuildingLevel>();
            var buildingRepository = new Repository<Building>();

            var resporceRepository = new Repository<Resource>();
            var factorRepository = new Repository<Factor>();


            if (buildingLvlRepository.Get().Count == 0 && buildingRepository.Get().Count != 0)
            {

                // Resources
                var metalCriteria = new Dictionary<string, string>();
                metalCriteria.Add("Name", "Metal");
                var metal = resporceRepository.Get(metalCriteria).First();

                var carbonCriteria = new Dictionary<string, string>();
                carbonCriteria.Add("Name", "Carbon");
                var carbon = resporceRepository.Get(carbonCriteria).First();

                var fuleCriteria = new Dictionary<string, string>();
                fuleCriteria.Add("Name", "Fule");
                var fule = resporceRepository.Get(fuleCriteria).First();

                
                //Factors
                var metalFactorCriteria = new Dictionary<string, string>();
                metalFactorCriteria.Add("Name", "Metal");
                var metalFactor = factorRepository.Get(metalFactorCriteria).First();

                var carbonFactorCriteria = new Dictionary<string, string>();
                carbonFactorCriteria.Add("Name", "Carbon");
                var carbonFactor = factorRepository.Get(carbonFactorCriteria).First();

                var fuleFactorCriteria = new Dictionary<string, string>();
                fuleFactorCriteria.Add("Name", "Fule");
                var fuleFactor = factorRepository.Get(fuleFactorCriteria).First();

                var researchFactorCriteria = new Dictionary<string, string>();
                researchFactorCriteria.Add("Name", "Research speed");
                var researchFactor = factorRepository.Get(researchFactorCriteria).First();

                var shipBuildFactorCriteria = new Dictionary<string, string>();
                shipBuildFactorCriteria.Add("Name", "Ship build speed");
                var shipBuildFactor = factorRepository.Get(shipBuildFactorCriteria).First();

                var buildFactorCriteria = new Dictionary<string, string>();
                buildFactorCriteria.Add("Name", "Build speed");
                var buildFactor = factorRepository.Get(buildFactorCriteria).First();
    

                // Creates levels for metal mine
                var metalMineCriteria = new Dictionary<string, string>();
                metalMineCriteria.Add("Name", "Metal mine");

                Building metalMine = buildingRepository.Get(metalMineCriteria).First();

                var buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 1,
                            BuildDuration = 100,

                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 100
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 30
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );

                buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 2,
                            BuildDuration = 300
                        };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 80
                    }
                };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 600
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 150
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 130
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );



                buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 3,
                            BuildDuration = 900
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 1900
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 320
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 210
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );



                buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 4,
                            BuildDuration = 1600
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 3400
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 600
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 340
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );


                buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 5,
                            BuildDuration = 2400
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 6200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 920
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 480
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );


                buildingLevel = new BuildingLevel()
                        {
                            Building = metalMine,
                            Level = 6,
                            BuildDuration = 4700
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 9000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 1100
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = metalFactor,
                        Value = 780
                    }
                };

                buildingLvlRepository.Create(
                        buildingLevel
                    );



                // Creates carbon extractor levels
                var carbonMineCriteria = new Dictionary<string, string>();
                carbonMineCriteria.Add("Name", "Carbon extractor");

                Building carbonExtr = buildingRepository.Get(carbonMineCriteria).First();

                buildingLevel = new BuildingLevel()
                        {
                            Building = carbonExtr,
                            Level = 1,
                            BuildDuration = 150
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 400
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 160
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = carbonFactor,
                        Value = 20
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = carbonExtr,
                            Level = 2,
                            BuildDuration = 380
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 900
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 340
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = carbonFactor,
                        Value = 90
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = carbonExtr,
                            Level = 3,
                            BuildDuration = 1100
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 1900
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 660
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = carbonFactor,
                        Value = 190
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = carbonExtr,
                            Level = 4,
                            BuildDuration = 1900
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 3200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 890
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = carbonFactor,
                        Value = 320
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                {
                    Building = carbonExtr,
                    Level = 5,
                    BuildDuration = 320
                };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 6400
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 1400
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = carbonFactor,
                        Value = 610
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );



                // Creates fule destilery levels
                var fuleDestCrit = new Dictionary<string, string>();
                fuleDestCrit.Add("Name", "Fule destilery");

                Building fuleDest = buildingRepository.Get(fuleDestCrit).First();

                buildingLevel = new BuildingLevel()
                        {
                            Building = fuleDest,
                            Level = 1,
                            BuildDuration = 250
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 500
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 230
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 25
                    }
                };

                buildingLvlRepository.Create(
                          buildingLevel
                    );


                buildingLevel = new BuildingLevel()
                        {
                            Building = fuleDest,
                            Level = 2,
                            BuildDuration = 450
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 1100
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 410
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 60
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );

                buildingLevel = new BuildingLevel()
                        {
                            Building = fuleDest,
                            Level = 3,
                            BuildDuration = 1100
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 2400
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 1000
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 155
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );



                // Creates solar palen
                var solarPlantCrit = new Dictionary<string, string>();
                solarPlantCrit.Add("Name", "Solar plant");

                Building solarPlant = buildingRepository.Get(solarPlantCrit).First();


                buildingLevel = new BuildingLevel()
                        {
                            Building = solarPlant,
                            Level = 1,
                            BuildDuration = 450
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 800
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 320
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 220
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 15
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = solarPlant,
                            Level = 2,
                            BuildDuration = 1150
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 2100
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 1000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 620
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 60
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = solarPlant,
                            Level = 3,
                            BuildDuration = 2600
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 4400
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 1800
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 1200
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = fuleFactor,
                        Value = 130
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                // Creates shipyard levels
                var shipyardCrit = new Dictionary<string, string>();
                shipyardCrit.Add("Name", "Shipyard");

                Building shipyard = buildingRepository.Get(shipyardCrit).First();

                buildingLevel = new BuildingLevel()
                        {
                            Building = shipyard,
                            Level = 1,
                            BuildDuration = 850
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 1200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 3000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 1000
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = shipyard,
                            Level = 2,
                            BuildDuration = 1700
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 3200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 8000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 3200
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );





                // Creates fule destilery levels
                var researchLabCrit = new Dictionary<string, string>();
                researchLabCrit.Add("Name", "Research lab");

                Building researchLab = buildingRepository.Get(researchLabCrit).First();


                buildingLevel = new BuildingLevel()
                        {
                            Building = researchLab,
                            Level = 1,
                            BuildDuration = 1000
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 1200
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 6000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 2200
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = researchFactor,
                        Value = 10
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );


                buildingLevel = new BuildingLevel()
                        {
                            Building = researchLab,
                            Level = 2,
                            BuildDuration = 1900
                        };

                buildingLevel.BuildingCosts = new List<BuildingCost>()
                {
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = metal,
                        Value = 3000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = carbon,
                        Value = 12000
                    },
                    new BuildingCost(){
                        BuildingLevel = buildingLevel,
                        Resource = fule,
                        Value = 4200
                    }
                };

                buildingLevel.BuildingFactorModifiers = new List<BuildingFactorModifier>()
                {
                    new BuildingFactorModifier(){
                        BuildingLevel = buildingLevel,
                        Factor = researchFactor,
                        Value = 40
                    }
                };

                buildingLvlRepository.Create(
                                buildingLevel
                            );

            }

        }
    }
}
