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
        public Rating()
        {
            InitializeComponent();
        }

        public int userId { get; set; }

        private async void button1_Click(object sender, EventArgs e)
        {
            string desc = this.Commentaire.Text;
            double rating = this.ratingControl1.Value;

            if (rating == 0)
            {
                MessageBox.Show("Veuillez donner une note");
                return;
            }
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
            this.Close();

        }
    }
}
