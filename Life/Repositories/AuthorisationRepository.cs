using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.Models;
using Life.ViewModels;
using Life.Factory;

namespace Life.Repositories
{
    class AuthorisationRepository
    {

        /// <summary>
        /// Registers user if email is unique
        /// </summary>
        /// <param name="userViewModel">Entered data</param>
        /// <returns>User if registerd, null otherwise</returns>
        public User Register(UserViewModel userViewModel)
        {
            var usrRepo = new Repository<User>();

            var user = usrRepo.Get(new Dictionary<string, string>() { { "Email", userViewModel.Email } }).FirstOrDefault();

            if (user != null)
            {
                return null;
            }

            var newUser = CreateUser(userViewModel);

            usrRepo.Create(newUser);

            return newUser;
        }

        public User CreateUser(UserViewModel userViewModel)
        {
            var salt = Hash.GenerateSalt();

            var newUser = new User()
            {
                Email = userViewModel.Email,
                PasswordHash = Hash.GenerateHash(userViewModel.Password, salt),
                PasswordSalt = salt,
                ResourcesUpdatedAt = DateTime.Now
            };

            newUser = UserFactory.CreateUserFactor(newUser);
            newUser = UserFactory.CreateUserResource(newUser);
            newUser = UserFactory.AddPlanet(newUser);

            return newUser;
        }

        /// <summary>
        /// Logs in user checking password with salt
        /// </summary>
        /// <param name="userViewModel">Enterd data</param>
        /// <returns>User if logedin, null otherwise</returns>
        public User Login(UserViewModel userViewModel)
        {
            var usrRepo = new Repository<User>();

            var user = usrRepo.Get(new Dictionary<string, string>() { { "Email", userViewModel.Email } }).FirstOrDefault();

            if (user == null)
            {
                return null;
            }

            var passwordHash = Hash.GenerateHash(userViewModel.Password, user.PasswordSalt);

            if (passwordHash.SequenceEqual(user.PasswordHash))
            {
                return user;
            }
            else
            {
                return null;
            }
        }

    }
}
