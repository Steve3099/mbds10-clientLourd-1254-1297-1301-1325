using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Product
    {
        public int id { get; set; }
        public string description { get; set; }
        public string product_name { get; set; }
        public string product_image { get; set; }
        public bool is_exchangeable { get; set; }
        public bool is_deleted { get; set; }
        public int first_owner_id { get; set; }
        public User first_owner { get; set; }
        public int actual_owner_id { get; set; }
        public User actual_owner { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime updating_date { get; set; }

        public Product()
        {
        }

        public Product(int id, string description, string product_name, string product_image, bool is_exchangeable, bool is_deleted, int first_owner_id, int actual_owner_id, DateTime creation_date, DateTime updating_date)
        {
            this.id = id;
            this.description = description;
            this.product_name = product_name;
            this.product_image = product_image;
            this.is_exchangeable = is_exchangeable;
            this.is_deleted = is_deleted;
            this.first_owner_id = first_owner_id;
            this.actual_owner_id = actual_owner_id;
            this.creation_date = creation_date;
            this.updating_date = updating_date;
        }
    }
}
