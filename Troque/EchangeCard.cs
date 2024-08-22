using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Troque.Model;

namespace Troque
{
    public partial class EchangeCard : UserControl
    {
        public EchangeCard(Exchange e)
        {
            this.exchange = e;
            InitializeComponent();
        }

        public Exchange exchange { get; set; }

        private void EchangeCard_Load(object sender, EventArgs e)
        {
            //owner propositon
            this.owner.Text = exchange.owner_proposition.User.Username;
            List<Product> listOwner = new List<Product>();
            listOwner = exchange.owner_proposition.Products;
            foreach (Product product in listOwner)
            {
                CardProduit cardProduit = new CardProduit();
                cardProduit.idProduit = product.id;
                cardProduit.nomProduit = product.product_name;
                cardProduit.description = product.description;
                cardProduit.setButtonVisibility(false);
                cardProduit.checkBox1.Visible = false;
                cardProduit.SetImageUrlAsync(product.product_image);
                
                this.flowLayoutPanelOwner.Controls.Add(cardProduit);
            }

            //taker proposition
            this.Taker.Text = exchange.taker_proposition.User.Username;
            List<Product> listTaker = new List<Product>();
            listTaker = exchange.taker_proposition.Products;
            foreach (Product product in listTaker)
            {
                CardProduit cardProduit = new CardProduit();
                cardProduit.idProduit = product.id;
                cardProduit.nomProduit = product.product_name;
                cardProduit.description = product.description;
                cardProduit.setButtonVisibility(false);
                cardProduit.SetImageUrlAsync(product.product_image);
                
                this.flowLayoutPanelTaker.Controls.Add(cardProduit);
            }
        }

        private void taker_Click(object sender, EventArgs e)
        {

        }
    }
}
