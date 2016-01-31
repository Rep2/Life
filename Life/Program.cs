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
            SetSessionFactory();

            CreateData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        ///  Inits session factory and container
        /// </summary>
        public static void SetSessionFactory(){
            var sessionFactory = SQLiteSessionFactory.CreateSessionFactory();

            if (!container.Kernel.HasComponent(typeof(ISessionFactory)))
            {
                container.Register(
                    Component.For(typeof(ISessionFactory))
                    .Instance(sessionFactory)
                    .IsDefault());
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
            BuildingLevelFactory.Init();

            UserFactory.Init();
        }
    }
}
