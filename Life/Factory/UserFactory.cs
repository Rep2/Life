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

            userRepositorie.Create(Register(userViewModel));

        }

        public static User MockUser(){

            var userViewModel = new UserViewModel() { 
                Email = "1234aaa2a@gmail.com",
                Password = "sdasdsdasdads"
            };

            return Register(userViewModel);
        }

        public static User Register(UserViewModel userViewModel){

            var salt = Hash.GenerateSalt();

            var user = new User()
            {
                Email = userViewModel.Email,
                PasswordHash = Hash.GenerateHash(userViewModel.Password, salt),
                PasswordSalt = salt,
                ResourcesUpdatedAt = DateTime.Now
            };

            user = CreateUserFactor(user);
            user = CreateUserResource(user);

            return user;
        }

        private static User CreateUserResource(User user){

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

        private static User CreateUserFactor(User user)
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

   
    }
}
