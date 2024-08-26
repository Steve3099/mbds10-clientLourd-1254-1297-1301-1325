using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("category_name")]
        public string Category_name { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        public Category()
        {
        }

        public Category(int id, string category_name, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            Category_name = category_name;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public override string ToString()
        {
            return Category_name; // This is what will be displayed in the ComboBox
        }
    }
}
