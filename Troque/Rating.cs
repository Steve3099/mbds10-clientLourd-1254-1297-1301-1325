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
    public partial class Rating : Form
    {
        public int userId { get; set; }
        public Rating(int id)
        {
            userId = id;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string desc = this.Commentaire.Text;
            double rating = (double)this.numericUpDown1.Value;
            
            if (rating == 0)
            {
                MessageBox.Show("Veuillez donner une note");
                return;
            }
            Console.WriteLine(userId);
            RatingApi ratingApi = new RatingApi();
            bool result = await ratingApi.sendRating(userId, desc, rating);
            //verif result
            if (result)
            {
                MessageBox.Show("Votre avis a été enregistré");
            }
            else {      
                MessageBox.Show("Erreur lors de l'enregistrement de votre avis");
            }
            //this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rating_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Minimum = 0;
            this.numericUpDown1.Maximum = 5;

        }
    }
}
