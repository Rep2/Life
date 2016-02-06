using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.Repositories;

namespace Life.Factory
{
    class FactorFactory
    {

        public static void Init()
        {

            var factorRepository = new Repository<Factor>();

            if (factorRepository.Get().Count == 0)
            {

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Metal",
                           Description = "Metal income per second",
                           InitialValue = 2.0
                       }
                    );

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Carbon",
                           Description = "Carbon income per second",
                           InitialValue = 1.0
                       }
                    );

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Fule",
                           Description = "Fule income per second",
                           InitialValue = 0.0
                       }
                    );

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Build speed",
                           Description = "Speed of building build",
                           InitialValue = 3.0
                       }
                    );


                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Ship build speed",
                           Description = "Speed of ship building",
                           InitialValue = 0.0
                       }
                    );

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Ship move speed",
                           Description = "Speed of ships",
                           InitialValue = 0.0
                       }
                    );

                factorRepository.Create(
                       new Factor()
                       {
                           Name = "Research speed",
                           Description = "Speed of researching",
                           InitialValue = 0.0
                       }
                    );
            }

        }

    }
}
