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
using Life.Test.Models;
using Life.ViewModels;

namespace Life.Test.DB
{
    public class DBTest
    {

        [Fact]
        public void SessionFactoryValidation()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

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
            Program.SetSessionFactory(true);

            // Creates new user
            var user = UserFactory.MockUser();

            var userRepository = new Repository<User>();

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

        /// <summary>
        /// Checks if repositories are initialized properly
        /// </summary>
        [Fact]
        public void RepositorieCheck()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            var userRepositor = new Repository<User>();

            Assert.NotNull(userRepositor);
        }

        /// <summary>
        /// Checks if building are created in db
        /// </summary>
        [Fact]
        public void MockDataBuildings()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            Program.CreateData();

            var buildingRepositorie = new Repository<Building>();

            var buildings = buildingRepositorie.Get();

            Assert.Equal(buildings.Count, 5);
            Assert.Equal(buildings.ElementAt(0).Name, "Metal mine");
        }

        /// <summary>
        /// Checks if researches are created in db
        /// </summary>
        [Fact]
        public void MockDataResearch()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            Program.CreateData();

            var researchRepositorie = new Repository<Research>();

            var researchs = researchRepositorie.Get();

            Assert.Equal(researchs.Count, 3);
            Assert.Equal(researchs.ElementAt(0).Name, "Energy converting");
            Assert.Equal(researchs.ElementAt(2).Name, "Laser technology");
        }

        /// <summary>
        /// Creates 200 planets with random position and checks if they are properly created
        /// Checks if planets are created in db
        /// </summary>
        [Fact]
        public void MockDataPlanets()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            Program.CreateData();

            var planetRepositorie = new Repository<Planet>();

            var planets = planetRepositorie.Get();

            Assert.Equal(planets.Count, 200);
            Assert.InRange(planets.ElementAt(2).Size, 150, 300);
            Assert.InRange(planets.ElementAt(150).Size, 150, 300);
        }

        [Fact]
        public void RegisterTest()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            var authorizationRepo = new AuthorisationRepository();

            var userViewModel = Create();

            // Creates new user
            Assert.NotNull(authorizationRepo.Register(userViewModel));
        }

        [Fact]
        public void DoubleRegisterTest()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            var authorizationRepo = new AuthorisationRepository();

            var userViewModel = Create();
            // Creates new user
            Assert.NotNull(authorizationRepo.Register(userViewModel));

            // Tries to register same user twice
            Assert.Null(authorizationRepo.Register(userViewModel));
        }

        [Fact]
        public void LoginTest()
        {
            // Setups container and session factory
            Program.SetSessionFactory(true);

            var authorizationRepo = new AuthorisationRepository();

            var userViewModel = Create();

            // Creates new user
            Assert.NotNull(authorizationRepo.Register(userViewModel));

            // Logs in the user
            var logedUser = authorizationRepo.Login(userViewModel);

            Assert.NotNull(logedUser);
        }

        /// <summary>
        /// Checks user creation
        /// </summary>
        [Fact]
        public void CreateUser()
        {
            var authRepo = new AuthorisationRepository();

            var user = authRepo.CreateUser(Create());

            Assert.NotNull(user);
        }

        [Fact]
        public void ResourceRepository()
        {
            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();

            Assert.NotNull(metal);
            Assert.Equal(metal.Name, "Metal");

            Assert.NotNull(carbon);
            Assert.Equal(carbon.Name, "Carbon");
        }

        /// <summary>
        /// Checks has enaugh resources for building func
        /// </summary>
        [Fact]
        public void UserBuildingCreateTrue()
        {
            Program.SetSessionFactory(true);
            Program.CreateData();

            var authRepo = new AuthorisationRepository();

            var user = authRepo.CreateUser(Create());

            Assert.NotNull(user);

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var buildingLevel = new BuildingLevel()
            {
                Level = 1,
                BuildingCosts = new List<BuildingCost>(){
                    new BuildingCost(){
                        Resource = metal,
                        Value = 100
                    },
                    new BuildingCost(){
                        Resource = carbon,
                        Value = 200
                    }
                }
            };

            Assert.True(user.UserHasReseourceForBuild(buildingLevel));
        }

        /// <summary>
        /// Checks has enaugh resources for building func
        /// </summary>
        [Fact]
        public void UserBuildingCreateFalse()
        {
            Program.SetSessionFactory(true);
            Program.CreateData();

            var authRepo = new AuthorisationRepository();

            var user = authRepo.CreateUser(Create());

            Assert.NotNull(user);

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var buildingLevel = new BuildingLevel()
            {
                Level = 1,
                BuildingCosts = new List<BuildingCost>(){
                    new BuildingCost(){
                        Resource = metal,
                        Value = 100
                    },
                    new BuildingCost(){
                        Resource = carbon,
                        Value = 400
                    }
                }
            };

            Assert.False(user.UserHasReseourceForBuild(buildingLevel));
        }

        [Fact]
        public void UserHasEnaughResourcesForResearchTrue()
        {
            Program.SetSessionFactory(true);
            Program.CreateData();

            var authRepo = new AuthorisationRepository();

            var user = authRepo.CreateUser(Create());

            Assert.NotNull(user);

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var researchLevel = new ResearchLevel()
            {
                Level = 1,
                ResearchCosts = new List<ResearchCost>(){
                    new ResearchCost(){
                        Resource = metal,
                        Value = 200
                    },
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 200
                    }
                }
            };

            Assert.True(user.UserHasResourcesForResearch(researchLevel));
        }

        [Fact]
        public void UserHasEnaughResourcesForResearchFalse()
        {
            Program.SetSessionFactory(true);
            Program.CreateData();

            var authRepo = new AuthorisationRepository();

            var user = authRepo.CreateUser(Create());

            Assert.NotNull(user);

            var resorceRepository = new Repository<Resource>();
            var metal = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Metal" } }).First();
            var carbon = resorceRepository.Get(new Dictionary<string, string>() { { "Name", "Carbon" } }).First();


            var researchLevel = new ResearchLevel()
            {
                Level = 1,
                ResearchCosts = new List<ResearchCost>(){
                    new ResearchCost(){
                        Resource = metal,
                        Value = 500
                    },
                    new ResearchCost(){
                        Resource = carbon,
                        Value = 200
                    }
                }
            };

            Assert.False(user.UserHasResourcesForResearch(researchLevel));
        }

        public UserViewModel Create()
        {
            var user = new UserViewModel()
            {
                Email = "test2@gmail.com",
                Password = "test"
            };

            return user;
        }
    }
}
