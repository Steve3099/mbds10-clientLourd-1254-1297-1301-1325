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
    public partial class ListExchange : Form
    {
        List<Exchange> listExchange = new List<Exchange>();
        public ListExchange()
        {
            InitializeComponent();
        }

        private async void ListExchange_Load(object sender, EventArgs e)
        {
            ExchangeApi exchangeApi = new ExchangeApi();
            listExchange = await exchangeApi.GetMyExchange();
            //this.flowLayoutPanel1.Controls.Clear();
            foreach(Exchange exchange in listExchange)
            {
                EchangeCard cardExchange = new EchangeCard(exchange);
                //cardExchange.exchange = exchange;
                /*cardExchange.idExchange = exchange.id;
                cardExchange.status = exchange.status;
                cardExchange.owner_proposition_id = exchange.owner_proposition_id;
                cardExchange.taker_proposition_id = exchange.taker_proposition_id;
                cardExchange.creation_date = exchange.creation_date;
                cardExchange.updating_date = exchange.updating_date;
                cardExchange.delivery_address = exchange.delivery_address;*/
                flowLayoutPanel1.Controls.Add(cardExchange);
            }
            //this.flowLayoutPanel1.Controls.Add()
        }

        public void RefreshExchanges()
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing controls
            ListExchange_Load(this, EventArgs.Empty); // Reload the exchanges
        }
    }
}
