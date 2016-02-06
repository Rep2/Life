using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.ViewModels;
using Life.Repositories;

namespace Life.Factory
{
    class UserFactory
    {

        public static void Init()
        {

            var userRepositorie = new Repository<User>();

            var userViewModel = new UserViewModel()
            {
                Email = "test@gmail.com",
                Password = "test"
            };

            new AuthorisationRepository().Register(userViewModel);
        }

        public static User MockUser(){

            var userViewModel = new UserViewModel() { 
                Email = "1234aaa2a@gmail.com",
                Password = "sdasdsdasdads"
            };

            return new AuthorisationRepository().Register(userViewModel);
        }

        public static User CreateUserData(User user)
        {
            user = CreateUserResource(user);
            user = CreateUserFactor(user);
            user = AddPlanet(user);

            return user;
        }
        
        public static User CreateUserResource(User user){

            user.UserResources = new List<UserResource>();

            var resorceRepository = new Repository<Resource>();

            foreach (Resource resource in resorceRepository.Get())
            {
                user.UserResources.Add(
                    new UserResource()
                    {
                        User = user,
                        Resource = resource,
                        Amount = resource.InitialValue
                    });
            }

            return user;

        }

        public static User CreateUserFactor(User user)
        {

            user.UserFactors = new List<UserFactor>();

            var factorRepository = new Repository<Factor>();

            foreach (Factor factor in factorRepository.Get())
            {
                user.UserFactors.Add(
                    new UserFactor()
                    {
                        User = user,
                        Factor = factor,
                        Value = factor.InitialValue
                    });
            }

            return user;
        }

        public static User AddPlanet(User user)
        {
            var repo = new Repository<Planet>();

            var planet = repo.Get().Where(b => b.User == null).First();

            if (user.Planets == null)
            {
                user.Planets = new List<Planet>();
            }

            planet.User = user;
            user.Planets.Add(planet);
      
            return user;
        }
    

    }
}
