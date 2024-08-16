using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troque.Model
{
    public class User
    {
        public int Id { get; set; }
        public  string Username { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role_id { get; set; }
        public string Role { get; set; }
        public string user_image { get; set; }
        public Boolean is_active { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime deleted_at { get; set; }


        public User()
        {
        }

        public User(int id, string username, string name, string address, string email, string password, int role_id, string role, string user_image, Boolean is_active, DateTime creation_date, DateTime deleted_at)
        {
            Id = id;
            Username = username;
            Name = name;
            this.address = address;
            Email = email;
            Password = password;
            Role_id = role_id;
            Role = role;
            this.user_image = user_image;
            this.is_active = is_active;
            this.creation_date = creation_date;
            this.deleted_at = deleted_at;
        }
        
    }
}
