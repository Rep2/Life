using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Life.ViewModels;
using Life.Repositories;
using System.Windows.Forms;
using Life.Models;

namespace Life.Controllers
{
    public class AuthorisationController
    {
        Authorisation authorisationForm;

        public AuthorisationController(Authorisation authorisationForm)
        {
            this.authorisationForm = authorisationForm;
        }

        public void ButtonClicked(UserViewModel userViewModel, bool isRegister)
        {

            var authRepo = new AuthorisationRepository();

            if (isRegister)
            {
                var user = authRepo.Register(userViewModel);

                if (user != null)
                {
                    ShowMainForm(user);
                }
                else
                {
                    MessageBox.Show("Email already in use. Try login instead");
                }
            }
            else
            {
                var user = authRepo.Login(userViewModel);

                if (user != null)
                {
                    ShowMainForm(user);
                }
                else
                {
                    MessageBox.Show("Login failed. Incorrect credentials");
                }
            }

        }

        private void ShowMainForm(User user)
        {
            authorisationForm.Hide();

            var form = new MainScreen(user);
            form.Show();

        }

    }
}
