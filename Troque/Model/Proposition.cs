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
        public int User_id { get; set; }
        public User User { get; set; }
        public DateTime Creation_date { get; set; }
        public DateTime Updating_date { get; set; }
        public bool Is_active { get; set; }

        public Proposition()
        {
        }

        public Proposition(int id, int user_id, DateTime creation_date, DateTime updating_date, bool is_active = true)
        {
            Id = id;
            User_id = user_id;
            Creation_date = creation_date;
            Updating_date = updating_date;
            Is_active = is_active;
        }
        
    }
}
