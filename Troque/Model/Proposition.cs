using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class Proposition
    {
        public int Id { get; set; }

        [JsonProperty("user_id")]
        public int User_id { get; set; }
        public User User { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public bool Is_active { get; set; }
        public List<Product> Products { get; set; }

        public Proposition()
        {
        }

        public Proposition(int id, int user_id, DateTime creation_date, DateTime updating_date, bool is_active = true)
        {
            Id = id;
            User_id = user_id;
            createdAt = creation_date;
            updatedAt = updating_date;
            Is_active = is_active;
        }
        
    }
}
