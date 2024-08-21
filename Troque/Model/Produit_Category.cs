using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Produit_Category
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Product_id { get; set; }
        public Product Product { get; set; }
        public int Category_id { get; set; }
        public Category Category { get; set; }

        public Produit_Category()
        {
        }

        public Produit_Category(int id, int product_id, int category_id)
        {
            Id = id;
            Product_id = product_id;
            Category_id = category_id;
        }
    }
}
