using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troque.Model
{
    public class Exchange
    {
        public int id { get; set; }
        public string status { get; set; }
        public int owner_proposition_id { get; set; }
        public Proposition owner_proposition { get; set; }
        public int taker_proposition_id { get; set; }
        public Proposition taker_proposition { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime updating_date { get; set; }
        public string delivery_address { get; set; }

        public Exchange()
        {
        }

        public Exchange(int id, string status, int owner_proposition_id, int taker_proposition_id, DateTime creation_date, DateTime updating_date, string delivery_address)
        {
            this.id = id;
            this.status = status;
            this.owner_proposition_id = owner_proposition_id;
            this.taker_proposition_id = taker_proposition_id;
            this.creation_date = creation_date;
            this.updating_date = updating_date;
            this.delivery_address = delivery_address;
        }
    }
}
