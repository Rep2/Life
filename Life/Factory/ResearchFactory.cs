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
           

            if (researchRepositorie.Get().Count == 0)
            {
                var energy = CreateEnergyResearch();

                researchRepositorie.Create(
                    new List<Research>()
                    {
                        energy,
                        CreateCombustionEngineResearch(),
                        CreateLaserResearch(energy)
                    }
                );
            }

        }

        public static Research CreateEnergyResearch()
        {
            var energy = new Research()
            {
                Name = "Energy converting",
                Description = "Allows basic types of energy converting"
            };

            energy.AddResearchLevels(
                new List<ResearchLevel>()
                {
                    new ResearchLevel(){
                        Level = 1,
                        Duration = 200,
                        ResearchLabLevel = 1
                    },
                    new ResearchLevel(){
                        Level = 2,
                        Duration = 600,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Level = 3,
                        Duration = 1500,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Level = 4,
                        Duration = 3400,
                        ResearchLabLevel = 4
                    }
                }
            );

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();
            var fule = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();


            var factorRepository = new Repository<Factor>();
            var buildFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Build speed" } }).First();

            energy.ResearchLevels.ElementAt(0).AddResearchLevelsCosts(
                new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 200
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 200
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 200
                    }
                }
            );

            energy.ResearchLevels.ElementAt(0).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        Value = 10
                    }
                }
            );

            energy.ResearchLevels.ElementAt(1).AddResearchLevelsCosts(
                new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 800
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 800
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 800
                    }
                }
            );

            energy.ResearchLevels.ElementAt(1).AddResearchLevelModifiers(
            new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        Value = 40
                    }
                }
            );

            energy.ResearchLevels.ElementAt(2).AddResearchLevelsCosts(
                new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 2400
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 2400
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 2400
                    }
                }
            );

            
            energy.ResearchLevels.ElementAt(2).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        Value = 80
                    }
                }
            );

            energy.ResearchLevels.ElementAt(3).AddResearchLevelsCosts(
                new List<ResearchCost>()
                {
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 4200
                    },
                    new ResearchCost(){
                        Resource = fule,
                        Value = 4200
                    },
                    new ResearchCost(){
                        Resource = metal,
                        Value = 4200
                    }
                }
            );

             energy.ResearchLevels.ElementAt(3).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = buildFactor,
                        Value = 110
                    }
                }
            );

            return energy;
        }


        private static Research CreateCombustionEngineResearch()
        {

            var combustionEngine = new Research()
            {
                Name = "Basic type of ship engine",
                Description = "Converts fule into enegry which is used to accelerate ships"
            };

            combustionEngine.AddResearchLevels(
                new List<ResearchLevel>()
                {
                    new ResearchLevel(){
                        Level = 1,
                        Duration = 400,
                        ResearchLabLevel = 1
                    },
                    new ResearchLevel(){
                        Level = 2,
                        Duration = 800,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Level = 3,
                        Duration = 2500,
                        ResearchLabLevel = 2
                    },
                    new ResearchLevel(){
                        Level = 4,
                        Duration = 6200,
                        ResearchLabLevel = 4
                    }
                }
            );

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();
            var fule = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();


            var factorRepository = new Repository<Factor>();
            var shipBuildFactor = factorRepository.Get(new Dictionary<string, string>() { { "Name", "Ship build speed" } }).First();


            combustionEngine.ResearchLevels.ElementAt(0).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        Value = 20
                    }
                }
                );

            combustionEngine.ResearchLevels.ElementAt(1).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        Value = 60,
                    }
                }
                );

            combustionEngine.ResearchLevels.ElementAt(2).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        Value = 120
                    }
                }
                );

            combustionEngine.ResearchLevels.ElementAt(3).AddResearchLevelModifiers(
                new List<ResearchFactorModifier>()
                {
                    new ResearchFactorModifier(){
                        Factor = shipBuildFactor,
                        ResearchLevel = combustionEngine.ResearchLevels.ElementAt(3),
                        Value = 190
                    }
                }
                );

            combustionEngine.ResearchLevels.ElementAt(0).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                }
                );

            combustionEngine.ResearchLevels.ElementAt(1).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                }
                );

            combustionEngine.ResearchLevels.ElementAt(2).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                }
                );

            combustionEngine.ResearchLevels.ElementAt(3).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                }
                );

            return combustionEngine;
        }

        private static Research CreateLaserResearch(Research energy)
        {
            var lasers = new Research()
            {
                Name = "Laser technology",
                Description = "Used to power basic weapons"
            };

            lasers.AddResearchLevels(
                new List<ResearchLevel>()
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
                }
                );

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();
            var fule = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Fule" } }).First();


            lasers.ResearchLevels.ElementAt(0).ResearchRequirment = energy.ResearchLevels.ElementAt(1);

            lasers.ResearchLevels.ElementAt(0).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                });

            lasers.ResearchLevels.ElementAt(3).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                });

            lasers.ResearchLevels.ElementAt(1).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                });

            lasers.ResearchLevels.ElementAt(2).AddResearchLevelsCosts(
                new List<ResearchCost>()
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
                });

            return lasers;
        }
    }
}
