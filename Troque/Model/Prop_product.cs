using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Prop_product
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public Product Product { get; set; }
        public int Prop_id { get; set; }
        public Proposition Prop { get; set; }

        public Prop_product()
        {
        }

        public Prop_product(int id, int product_id, int prop_id)
        {
            Id = id;
            Product_id = product_id;
            Prop_id = prop_id;
        }
        
    }
}
