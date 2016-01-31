using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.Repositories;

namespace Life.Factory
{
    class PlanetFactory
    {
        private static Random random = new Random();

        public static void Init() {

            var planetRepositorie = new Repository<Planet>();

            if (planetRepositorie.Get().Count == 0)
            {

                for (int i = 0; i < 200; i++)
                {

                    planetRepositorie.Create(
                            Create()
                        );

                }

            }
        }

        public static Planet Create()
        {
            var planet = new Planet(){
                Location = RandomLocation(),
                Size = random.Next(150, 300),
                Temperature = random.Next(-80, 200),
                CurrentlyBuilding = null
            };

            planet.BuiltBuildings = new List<BuiltBuilding>();

            return planet;
        }

        public static Location RandomLocation()
        {

            return new Location(){
                X = random.NextDouble() * 100000,
                Y = random.NextDouble() * 100000,
                Z = random.NextDouble() * 100000
            };

        }
    }
}
