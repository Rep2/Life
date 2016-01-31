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
                        new Building()
                        {
                            Name = "Metal mine",
                            Description = "Mines metal ore and refines it"
                        }
                    );

                buildingRepository.Create(
                        new Building()
                        {
                            Name = "Carbon extractor",
                            Description = "Extracts pure carbon from planets soil"
                        }
                    );

                buildingRepository.Create(
                        new Building()
                        {
                            Name = "Fule destilery",
                            Description = "Extracts basic alkanes from planets harsh environment"
                        }
                    );

                buildingRepository.Create(
                        new Building()
                        {
                            Name = "Solar plant",
                            Description = "Creates energy by converting solar power to electricity"
                        }
                    );

                buildingRepository.Create(
                        new Building()
                        {
                            Name = "Shipyard",
                            Description = "Allows production of space ships"
                        }
                    );

                buildingRepository.Create(
                        new Building()
                        {
                            Name = "Research lab",
                            Description = "Allows reasearch of different types of researches"
                        }
                    );
            }

        }

    }
}
