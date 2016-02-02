using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Life.Models;
using NHibernate;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Life.Factory;
using Life.Controllers;

namespace Life
{
    static class Program
    {

        public static WindsorContainer container = new WindsorContainer();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set true to reset db
            SetSessionFactory(false);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorisation(new AuthorisationController()));
        }

        /// <summary>
        ///  Inits session factory and container
        /// </summary>
        public static void SetSessionFactory(bool resetDB){
           
            var sessionFactory = SQLiteSessionFactory.CreateSessionFactory(resetDB);

            if (!container.Kernel.HasComponent(typeof(ISessionFactory)))
            {
                container.Register(
                    Component.For(typeof(ISessionFactory))
                    .Instance(sessionFactory)
                    .IsDefault());
            }

            if (resetDB)
            {
                CreateData();
            }
        }

        /// <summary>
        /// Init db data. Not needed in production
        /// </summary>
        public static void CreateData()
        {
            ResourceFactory.Init();
            FactorFactory.Init();

            PlanetFactory.Init();

            ResearchFactory.Init();

            BuildingFactory.Init();

            UserFactory.Init();
        }
       
    }
}
