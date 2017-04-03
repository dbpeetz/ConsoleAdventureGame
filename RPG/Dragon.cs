using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Dragon : Enemy
    {
        Dictionary<string, int> DrgAttacks = new Dictionary<string, int>
       {
           {"Fire Blast", 50 },
           {"Tail Whip", 25 },
           {"Omega Blast", 70 }
       };

        public Dragon()
        {
            this.PowerLevel = 250;
            this.Name = "Dragon";
        }

        public void DragonAttack(Player p)
        {
            Attack(p, DrgAttacks, this.Name);
        }

    }
}
