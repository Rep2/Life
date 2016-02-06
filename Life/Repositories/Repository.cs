using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using NHibernate.Criterion;

namespace Life.Repositories
{
    public class Repository<T> where T : Model
    {
        protected ISessionFactory factory;

        public Repository()
        {
            factory = Program.container.Resolve<ISessionFactory>();
        }

        public List<T> Get()
        {
            using (ISession session = factory.OpenSession())
            {
                return session.QueryOver<T>().List<T>().ToList();
            }
        }

        public T Get(int id)
        {
            using (ISession session = factory.OpenSession())
            {
                return session.Load<T>(id);
            }

        }

        public List<T> Get(Dictionary<string, string> criteria)
        {
            using (ISession session = factory.OpenSession())
            {
                var sessionCriteria = session.CreateCriteria<T>();

                foreach(KeyValuePair<string, string> crit in criteria){
                    sessionCriteria.Add(Restrictions.Eq(crit.Key, crit.Value));
                }

                return sessionCriteria.List<T>().ToList();
            }


        }

        public void Create(T model)
        {
            using (ISession session = factory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Save(model);
                    session.Transaction.Commit();
                }
            }
        }

        public void Create(List<T> models)
        {
            using (ISession session = factory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    foreach (T model in models)
                    {
                        session.Save(model);
                    }

                    session.Transaction.Commit();
                }
            }
        }

        public void Delete(T model)
        {
            using (ISession session = factory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Delete(model);
                    session.Transaction.Commit();
                }
            }
        }

        public void Update(T model)
        {
            using (ISession session = factory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    session.Update(model);
                    session.Transaction.Commit();
                }
            }
        }

    }
}
