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
           {"Fire Blast", 90 },
           {"Wing Attack", 98 },
           {"Omega Blast", 110 }
       };

        public Dragon()
        {
            this.PowerLevel = 275;
            this.Name = "Dragon";
        }

        public void DragonAttack(dynamic p)
        {
            Attack(p, DrgAttacks, this.Name);
        }

    }
}
