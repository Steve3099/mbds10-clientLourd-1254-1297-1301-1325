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
    public partial class Dashboard : Form
    {
        public List<Product> Products { get; set; }
        public Dashboard()
        {
            InitializeComponent();
            loadMyProducts();
            //populateItems();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            AjoutProduit ajoutProduit = new AjoutProduit();
            ajoutProduit.ShowDialog();
        }

        private async void loadMyProducts()
        {
            ProductApi produitapi = new ProductApi();

            //List<Model.Product> products = produitapi.GetProducts();
            int userId = AuthTokenManager.id;
            this.Products = await produitapi.GetAllProductsUser();
            //listView1.Controls.Clear();

            foreach (Product product in Products)
            {
                Console.WriteLine(product.id);
                CardProduit cardProduit = new CardProduit();
                cardProduit.idProduit = product.id;
                cardProduit.nomProduit = product.product_name;
                cardProduit.description = product.description;
                cardProduit.userId = product.actual_owner_id;
                cardProduit.setCheckBoxVisibility(false);
                await cardProduit.SetImageUrlAsync(product.product_image);
                foreach (Category category in product.categories)
                {
                    cardProduit.categorie += category.Category_name +" ";
                }
                flowLayoutPanel1.Controls.Add(cardProduit);
            }
        }

        public async void populateItems()
        {
            CardProduit[] listecardProduits = new CardProduit[10];
            //listView1.Controls.Clear();
            
            foreach (Product product in Products)
            {
                CardProduit cardProduit = new CardProduit();
                cardProduit.nomProduit = product.product_name;
                flowLayoutPanel1.Controls.Add(cardProduit);
            }
            /*for (int i = 0;i<10;i++)
            {
                listecardProduits[i] = new CardProduit();
                listecardProduits[i].nomProduit = "Produit " + i;
                flowLayoutPanel1.Controls.Add(listecardProduits[i]);
            }*/
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //populateItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjoutProduit ajoutProduit = new AjoutProduit();
            ajoutProduit.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listeEchangebutton_Click(object sender, EventArgs e)
        {
            ListExchange listExchange = new ListExchange();
            listExchange.ShowDialog();
        }
    }
}
