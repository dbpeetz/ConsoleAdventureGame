using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Hunter : Player
    {
        public int HP { get; set; } = 200;
        Dictionary<string, int> HuntAttacks = new Dictionary<string, int>
        {
            {"Concussive Shot", 80 },
            {"Black Arrow", 95 },
            {"Kill Shot", 105 }
        };

        public Hunter(string name)
        {
            this.PlayerName = name;
            HP = 200;
        }

        public void HuntAttack(dynamic e)
        {
            Attack(e, HuntAttacks, this.PlayerName);
        }
    }
}
