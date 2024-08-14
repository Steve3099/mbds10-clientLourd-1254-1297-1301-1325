using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Category_name { get; set; }

        public Category()
        {
        }

        public Category(int id, string category_name)
        {
            Id = id;
            Category_name = category_name;
        }
    }
}
