using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Character
    {
        public Character(int id, int userId, string name, string type, int attackPoints, int defencePoint, int healthPoints, DateTime dateCreated)
        {
            Id = id;
            UserId = userId;
            Name = name;
            Type = type;
            AttackPoints = attackPoints;
            DefencePoint = defencePoint;
            HealthPoints = healthPoints;
            DateCreated = dateCreated;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public virtual User User { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int AttackPoints { get; set; }
        [Required]
        public int DefencePoint { get; set; }
        [Required]
        public int HealthPoints { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
