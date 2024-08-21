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
        List<Product> MyProducts { get; set; }
        List<Product> HisProducts { get; set; }
        public CreateEchange()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateEchange_Load(object sender, EventArgs e)
        {
            loadMyProducts();
        }

        private async void loadMyProducts()
        {
            ProductApi produitapi = new ProductApi();

            //List<Model.Product> products = produitapi.GetProducts();
            int userId = AuthTokenManager.id;
            this.MyProducts = await produitapi.GetProductsUser(userId);
            CardProduit[] listecardProduits = new CardProduit[10];
            //listView1.Controls.Clear();
            //Console.WriteLine(MyProducts.Count);
            foreach (Product product in MyProducts)
            {
                CardProduit cardProduit = new CardProduit();
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
    }
}
