using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Leviathan : Enemy
    {
        Dictionary<string, int> LevAttacks = new Dictionary<string, int>
        {
            {"Wave Crash", 35 },
            {"Hyper Beam", 55 },
            {"Serpent Bind", 70 }
        };

        public Leviathan()
        {
            this.PowerLevel = 225;
            this.Name = "Leviathan";
        }

        public void LeviathanAttack(Player p)
        {
            Attack(p, LevAttacks, this.Name);
        }
    }
}
