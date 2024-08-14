using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Login_Click(object sender, EventArgs e)
        {
            string email = this.textBoxemail.Text;
            string password = this.textBoxPassword.Text;

            var auth = new Api.Authentification();
            bool success = await auth.Login(email, password);
            Console.Write(success);
        }
    }
}
