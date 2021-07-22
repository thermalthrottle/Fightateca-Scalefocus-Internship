using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class BattleResults
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int WinnerId { get; set; }
        [Required]
        public virtual ICollection<Character> Winner { get; set; }
        [Required]
        public int LoserId { get; set; }
        [Required]
        public virtual ICollection<Character> Loser { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
