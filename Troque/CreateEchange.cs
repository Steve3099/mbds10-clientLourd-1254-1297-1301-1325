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
using Troque.Model;

namespace Troque
{
    public partial class CreateEchange : Form
    {
        public int idOtherUser { get; set; }
        List<Product> MyProducts { get; set; }
        List<Product> HisProducts { get; set; }
        public CreateEchange(int idother)
        {
            this.idOtherUser = idother;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateEchange_Load(object sender, EventArgs e)
        {
            loadMyProducts();
            loadHisProducts();
        }

        private async void loadMyProducts()
        {
            ProductApi produitapi = new ProductApi();

            //List<Model.Product> products = produitapi.GetProducts();
            int userId = AuthTokenManager.id;
            this.MyProducts = await produitapi.GetProductsUser(userId);
            //listView1.Controls.Clear();
            //Console.WriteLine(MyProducts.Count);
            foreach (Product product in MyProducts)
            {
                CardProduit cardProduit = new CardProduit();
                cardProduit.idProduit = product.id;
                cardProduit.nomProduit = product.product_name;
                cardProduit.description = product.description;
                cardProduit.setButtonVisibility(false);
                await cardProduit.SetImageUrlAsync(product.product_image);
                foreach (Category category in product.categories)
                {
                    cardProduit.categorie += category.Category_name + " ";
                }
                flowLayoutPanelMe.Controls.Add(cardProduit);
            }
        }

        private async void loadHisProducts()
        {
            ProductApi produitapi = new ProductApi();

            //List<Model.Product> products = produitapi.GetProducts();
            int userId = idOtherUser;
            this.HisProducts = await produitapi.GetProductsUser(userId);
            //listView1.Controls.Clear();
            //Console.WriteLine(MyProducts.Count);
            int i = 0;
            foreach (Product product in HisProducts)
            {
                if (i == 0)
                {
                    this.labelOtherUser.Text = "Produits de " + product.actual_owner.Username;
                    i++;
                }
                
                CardProduit cardProduit = new CardProduit();
                cardProduit.idProduit = product.id;
                cardProduit.nomProduit = product.product_name;
                cardProduit.description = product.description;
                cardProduit.setButtonVisibility(false);
                await cardProduit.SetImageUrlAsync(product.product_image);
                foreach (Category category in product.categories)
                {
                    cardProduit.categorie += category.Category_name + " ";
                }
                flowLayoutPanelHe.Controls.Add(cardProduit);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            List<int> myProducts = new List<int>();
            List<int> hisProducts = new List<int>();
            foreach (CardProduit cardProduit in flowLayoutPanelMe.Controls)
            {
                if (cardProduit.checkBox1.Checked)
                {
                    myProducts.Add(cardProduit.idProduit);
                }
            }
            foreach (CardProduit cardProduit in flowLayoutPanelHe.Controls)
            {
                if (cardProduit.checkBox1.Checked)
                {
                    hisProducts.Add(cardProduit.idProduit);
                }
            }
            if (myProducts.Count == 0 || hisProducts.Count == 0)
            {
                MessageBox.Show("Veuillez selectionner au moins un produit de chaque liste");
                return;
            }
            string deliveryadress = this.Deliveryaddress.Text;
            //verif delivery adress
            if (deliveryadress == "")
            {
                MessageBox.Show("Veuillez renseigner une adresse de livraison");
                return;
            }
            try
            {
                ExchangeApi exchangeApi = new ExchangeApi();
                Exchange result = await exchangeApi.Exchangeproduit(deliveryadress, hisProducts, myProducts, this.idOtherUser, AuthTokenManager.id);
                if (result != null)
                {
                    MessageBox.Show("Echange effectué avec succès");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'échange");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
