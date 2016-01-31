using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.Repositories;

namespace Life.Factory
{
    class ResearchFactory
    {

        public static void Init()
        {

            var researchRepositorie = new Repository<Research>();
            var resourceRepositorie = new Repository<Resource>();
            var factorRepository = new Repository<Factor>();

            if (researchRepositorie.Get().Count == 0)
            {

                // Resources
                var metalCriteria = new Dictionary<string, string>();
                metalCriteria.Add("Name", "Metal");
                var metal = resourceRepositorie.Get(metalCriteria).First();

                var carbonCriteria = new Dictionary<string, string>();
                carbonCriteria.Add("Name", "Carbon");
                var carbon = resourceRepositorie.Get(carbonCriteria).First();

                var fuleCriteria = new Dictionary<string, string>();
                fuleCriteria.Add("Name", "Fule");
                var fule = resourceRepositorie.Get(fuleCriteria).First();

                // Factors
                var researchFactorCriteria = new Dictionary<string, string>();
                researchFactorCriteria.Add("Name", "Research speed");
                var researchFactor = factorRepository.Get(researchFactorCriteria).First();

                var shipBuildFactorCriteria = new Dictionary<string, string>();
                shipBuildFactorCriteria.Add("Name", "Ship build speed");
                var shipBuildFactor = factorRepository.Get(shipBuildFactorCriteria).First();

                var buildFactorCriteria = new Dictionary<string, string>();
                buildFactorCriteria.Add("Name", "Build speed");
                var buildFactor = factorRepository.Get(buildFactorCriteria).First();


                var energy = new Research()
                    {
                        Name = "Energy converting",
                        Description = "Allows basic types of energy converting"
                    };

                energy.ResearchLevels = new List<ResearchLevel>()
                {
                    new ResearchLevel(){
                        Research = energy,
                        Level = 1,
                        Duration = 200,
                        ResearchLabLevel = 1
                    },
                    new ResearchLevel(){
                        Research = energy,
                        Level = 2,
                        Duration = 600,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Research = energy,
                        Level = 3,
                        Duration = 1500,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Research = energy,
                        Level = 4,
                        Duration = 3400,
                        ResearchLabLevel = 4
                    }
                };

                energy.ResearchLevels.ElementAt(0).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(0)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(0)
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(0)
                    }
                };

                energy.ResearchLevels.ElementAt(0).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        ResearchLevel = energy.ResearchLevels.ElementAt(0),
                        Value = 10
                    }
                };

                energy.ResearchLevels.ElementAt(1).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        ResearchLevel = energy.ResearchLevels.ElementAt(1),
                        Value = 40
                    }
                };

                energy.ResearchLevels.ElementAt(2).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        ResearchLevel = energy.ResearchLevels.ElementAt(2),
                        Value = 80
                    }
                };

                energy.ResearchLevels.ElementAt(3).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        ResearchLevel = energy.ResearchLevels.ElementAt(3),
                        Value = 110
                    }
                };

                energy.ResearchLevels.ElementAt(1).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 800,
                        ResearchLevel = energy.ResearchLevels.ElementAt(1)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 800,
                        ResearchLevel = energy.ResearchLevels.ElementAt(1)
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 800,
                        ResearchLevel = energy.ResearchLevels.ElementAt(1)
                    }
                };

                energy.ResearchLevels.ElementAt(2).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 2400,
                        ResearchLevel = energy.ResearchLevels.ElementAt(2)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 2400,
                        ResearchLevel = energy.ResearchLevels.ElementAt(2)
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 2400,
                        ResearchLevel = energy.ResearchLevels.ElementAt(2)
                    }
                };

                energy.ResearchLevels.ElementAt(3).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 4200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(3)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 4200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(3)
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 4200,
                        ResearchLevel = energy.ResearchLevels.ElementAt(3)
                    }
                };

                researchRepositorie.Create(
                    energy
                    );

                var combustionEngine = new Research()
                {
                    Name = "Basic type of ship engine",
                    Description = "Converts fule into enegry which is used to accelerate ships"
                };

                combustionEngine.ResearchLevels = new List<ResearchLevel>()
                {
                    new ResearchLevel(){
                        Research = combustionEngine,
                        Level = 1,
                        Duration = 400,
                        ResearchLabLevel = 1
                    },
                    new ResearchLevel(){
                        Research = combustionEngine,
                        Level = 2,
                        Duration = 800,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Research = combustionEngine,
                        Level = 3,
                        Duration = 2500,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Research = combustionEngine,
                        Level = 4,
                        Duration = 6200,
                        ResearchLabLevel = 4
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(0).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(0),
                        Value = 20
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(1).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(1),
                        Value = 60,
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(2).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(2),
                        Value = 120
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(3).ResearchFactorModifiers = new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(3),
                        Value = 190
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(0).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 400,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(0)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 800,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(0)
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(1).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 1400,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(1)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 2300,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(1)
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(2).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 2500,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(2)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 4100,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(2)
                    }
                };

                combustionEngine.ResearchLevels.ElementAt(3).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 4100,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(3)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 6500,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(3)
                    }
                };

                researchRepositorie.Create(
                    combustionEngine
                    );

                var lasers = new Research()
                {
                    Name = "Laser technology",
                    Description = "Used to power basic weapons"
                };

                lasers.ResearchLevels = new List<ResearchLevel>()
                {
                    new ResearchLevel(){
                        Research = lasers,
                        Level = 1,
                        Duration = 600,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Research = lasers,
                        Level = 2,
                        Duration = 1100,
                        ResearchLabLevel = 3
                    },
                    new ResearchLevel(){
                        Research = lasers,
                        Level = 3,
                        Duration = 3100,
                        ResearchLabLevel = 3
                    },
                    new ResearchLevel(){
                        Research = lasers,
                        Level = 4,
                        Duration = 9000,
                        ResearchLabLevel = 6
                    }
                };

                lasers.ResearchLevels.ElementAt(0).ResearchRequirment = energy.ResearchLevels.ElementAt(1);

                lasers.ResearchLevels.ElementAt(0).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 700,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(0)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 400,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(0)
                    }
                };

                lasers.ResearchLevels.ElementAt(3).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 4700,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(3)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 2400,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(3)
                    }
                };

                lasers.ResearchLevels.ElementAt(1).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 1400,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(1)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 1100,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(1)
                    }
                };

                lasers.ResearchLevels.ElementAt(2).ResearchCosts = new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 2700,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(2)
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 1900,
                        ResearchLevel = lasers.ResearchLevels.ElementAt(2)
                    }
                };

                researchRepositorie.Create(
                    lasers
                    );

            }

        }

    }
}
