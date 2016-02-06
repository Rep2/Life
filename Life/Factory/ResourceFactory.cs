using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Repositories;
using Life.Models;

namespace Life.Factory
{
    class ResourceFactory
    {

        /// <summary>
        /// Creates all resources
        /// </summary>
        public static void Init()
        {
            var resourceRepository = new Repository<Resource>();
         
            if (resourceRepository.Get().Count == 0)
            {

                resourceRepository.Create(
                    new Resource()
                    {
                        Name = "Metal",
                        Description = "Basic resource used to build",
                        InitialValue = 200.0
                    }
                    );

                resourceRepository.Create(
                    new Resource()
                    {
                        Name = "Carbon",
                        Description = "Resource used as basic organic building block",
                        InitialValue = 300.0
                    }
                    );

                resourceRepository.Create(
                    new Resource()
                    {
                        Name = "Fule",
                        Description = "Used to power other buildings",
                        InitialValue = 100.0
                    }
                    );
            }
        }

    }
}
