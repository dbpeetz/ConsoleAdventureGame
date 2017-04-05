using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior : Player
    {
        public int HP { get; set; } = 250;
        Dictionary<string, int> WarAttacks = new Dictionary<string, int>
        {
            {"Heroic Strike", 65 },
            {"Raging Blow", 75 },
            {"Overpower", 90 }
        };

        public Warrior(string name)
        {
            this.PlayerName = name;
            HP = 250;
        }

        public void WarAttack(dynamic e)
        {
            Attack(e, WarAttacks, this.PlayerName);
        }
    }
}
