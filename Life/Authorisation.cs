using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Life.Controllers;

namespace Life
{
    public partial class Authorisation : Form
    {
        private bool isRegister = false;

        public AuthorisationController controller { get; set; }

        public Authorisation()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isRegister)
            {
                button1.Text = "Login";
                label3.Hide();
                textBox3.Hide();
                linkLabel1.Text = "Register";
            }
            else
            {
                button1.Text = "Register";
                label3.Show();
                textBox3.Show();
                linkLabel1.Text = "Login";
            }

            isRegister = !isRegister;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Field Username is required");
                return;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show("Field Password is required");
                return;
            }

            if (isRegister)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Field Repeat password is required");
                    return;
                }

                if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
            }

            controller.ButtonClicked(
                new ViewModels.UserViewModel()
                {
                    Email = textBox1.Text,
                    Password = textBox2.Text
                },
                isRegister
                );
        }

    }
}
