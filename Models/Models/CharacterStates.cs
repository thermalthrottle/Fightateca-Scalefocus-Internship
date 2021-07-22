using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class CharacterStates : Character
    {
        public CharacterStates(int id, int userId, string name, string type, int attackPoints, int defencePoint, int healthPoints, DateTime dateCreated) : base(id, userId, name, type, attackPoints, defencePoint, healthPoints, dateCreated){}
    }
}
