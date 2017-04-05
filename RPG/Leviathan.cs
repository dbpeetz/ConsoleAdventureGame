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
            {"Wave Crash", 65 },
            {"Hyper Beam", 80 },
            {"Serpent Bind", 100 }
        };

        public Leviathan()
        {
            this.PowerLevel = 325;
            this.Name = "Leviathan";
        }

        public void LeviathanAttack(Player p)
        {
            Attack(p, LevAttacks, this.Name);
        }

    }
}
