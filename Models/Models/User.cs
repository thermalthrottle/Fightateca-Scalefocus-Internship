using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class User
    {
        public User(int id, int username, int password, bool userRole, DateTime dateCreated)
        {
            Id = id;
            Username = username;
            Password = password;
            UserRole = userRole;
            DateCreated = dateCreated;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int Username { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public bool UserRole { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Character> characters { get; set; }
    }
}
