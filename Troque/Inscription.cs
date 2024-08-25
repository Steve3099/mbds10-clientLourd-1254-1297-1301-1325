using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troque.Api;

namespace Troque
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private async void buttonInscription_Click(object sender, EventArgs e)
        {
            string username = this.textBoxExtUsername.Text;
            string email = this.textBoxExtEmail.Text;
            string password = this.textBoxExtPassword.Text;
            string address = this.textBoxExtAddress.Text;
            //controle des champs
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            //ajout de l'utilisateur
            Authentification auth = new Authentification();
            bool success = await auth.Inscription(username, email, password, address);
            if (success)
            {
                MessageBox.Show("Inscription success");
                this.Close();
            }
            else
            {
                MessageBox.Show("Inscription failed");
                this.Close();
            }

        }
    }
}
