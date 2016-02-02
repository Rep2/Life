using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Cfg;
using Life.Factory;

namespace Life
{
    public static class SQLiteSessionFactory
    {
        public static ISessionFactory CreateSessionFactory(bool resetDB)
        {
            Configuration c = new Configuration();
            c.Configure();

            // Adds assembly to config
            c.AddAssembly(Assembly.GetCallingAssembly());

            if (resetDB)
            {
                new SchemaExport(c).Execute(true, true, false);

            }

            return c.BuildSessionFactory();
        }

    }

}
