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
    public partial class EchangeCard : UserControl
    {
        public EchangeCard(Exchange e)
        {
            this.exchange = e;
            //disable buuton accepter et refuser si le statu de l'echange n'est pas created
            
            InitializeComponent();
            if (e.status != "CREATED")
            {
                buttonAccepter.Visible = false;
                buttonRefuser.Visible = false;
            }
        }

        public Exchange exchange { get; set; }

        private void controlOwnership()
        {
            if(this.exchange.matchType == "TAKER")
            {
                this.buttonAccepter.Visible = false;
                this.buttonRefuser.Visible = false;
            }
        }

        private void EchangeCard_Load(object sender, EventArgs e)
        {
            //show status of exchange
            //Console.WriteLine(exchange.owner_proposition_id);
            this.Status.Text = exchange.status;
            this.buttonrecevoir.Visible = false;
            if (exchange.status == "ACCEPTED")
            {
                this.Status.ForeColor = Color.Green;
                this.buttonrecevoir.Visible = true;
            }
            else if (exchange.status == "CANCELLED")
            {
                this.Status.ForeColor = Color.Red;
            }
            else if (exchange.status != "ACCEPTED")
            {
                this.Status.ForeColor = Color.Blue;
                this.buttonrecevoir.Visible = false;
            }
            else
            {
                this.Status.ForeColor = Color.Blue;
            }
            controlOwnership();
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
                cardProduit.checkBox1.Visible = false;
                cardProduit.SetImageUrlAsync(product.product_image);
                
                this.flowLayoutPanelTaker.Controls.Add(cardProduit);
            }
        }

        private void taker_Click(object sender, EventArgs e)
        {

        }

        private async void buttonAccepter_Click(object sender, EventArgs e)
        {
            ExchangeApi exchangeApi = new ExchangeApi();
            try
            {
                var res = await exchangeApi.AcceptExchange(exchange.id);
                if (res == true)
                {
                    ListExchange parentForm = this.FindForm() as ListExchange;
                    parentForm?.RefreshExchanges();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonRefuser_Click(object sender, EventArgs e)
        {

        }

        private void Taker_Click_1(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)
        {

        }

        private async void buttonrecevoir_Click(object sender, EventArgs e)
        {
            ExchangeApi exchangeApi = new ExchangeApi();
            try
            {


                var res = await exchangeApi.ReceiveExchange(exchange.id);
                if (res == true)
                {
                    Rating rating = null;
                if (exchange.taker_proposition.User.Id == AuthTokenManager.id)
                {
                    rating = new Rating(exchange.owner_proposition.User.Id);
                    rating.userId = exchange.owner_proposition.User_id;
                }
                else
                {
                    rating = new Rating(exchange.taker_proposition.User.Id);
                    rating.userId = exchange.taker_proposition.User_id;
                }
                    rating.ShowDialog();
                    ListExchange parentForm = this.FindForm() as ListExchange;
                    parentForm?.RefreshExchanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
