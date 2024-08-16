using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque
{
    public class Role
    {
        public int Id { get; set; }
        public string Role_name { get; set; }

        public Role()
        {
        }

        public Role(int id, string role_name)
        {
            Id = id;
            Role_name = role_name;
        }
    }
}
