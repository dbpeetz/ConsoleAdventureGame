using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Mage : Player
    {
        public int HP { get; set; } = 175;
        Dictionary<string, int> MageAttacks = new Dictionary<string, int>
        {
            {"Arcane Blast", 90 },
            {"Ray of Frost", 100 },
            {"Pyroblast", 120 }
        };

        public Mage(string name)
        {
            this.PlayerName = name;
            HP = 175;
        }

        public void MageAttack(dynamic e)
        {
            Attack(e, MageAttacks, this.PlayerName);
        }
    }
}
