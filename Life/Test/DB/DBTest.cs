using NHibernate;
using NHibernate.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Life.Models;
using Life.Factory;
using Life.Repositories;

namespace Life.Test.DB
{
    public class DBTest
    {

        [Fact]
        public void SessionFactoryValidation()
        {
            // Setups container and session factory
            Program.SetSessionFactory();

            // Gets session factory
            var factory = Program.container.Resolve<ISessionFactory>();

            // Checks session factory and db connectivity
            Assert.IsType(typeof(SessionFactoryImpl), factory);
            Assert.NotNull(factory);
        }

        /// <summary>
        /// Checks database connectivity with user creation and deletion
        /// </summary>
        [Fact]
        public void DBBasicOperationValidation()
        {
            // Setups container and session factory
            Program.SetSessionFactory();

            var user = UserFactory.MockUser();

            var userRepository = new Repository<User>();
            
            // Creates new user
            userRepository.Create(user);

            // Fetches user from db
            var fetchedUser = userRepository.Get(user.Id);

            // Checks if they are equal
            Assert.Equal(user.Id, fetchedUser.Id);
            Assert.Equal(user.Email, fetchedUser.Email);

            // Deletes created user
            userRepository.Delete(user);

            // Checks that user is deleted
            Assert.Throws<NHibernate.ObjectNotFoundException>(() => userRepository.Get(user.Id));
        }

    }
}
