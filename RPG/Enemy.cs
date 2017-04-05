using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Enemy
    {
        public Random rnd = new Random();
        public string Name { get; set; }
        public int PowerLevel { get; set; }



        public void Attack(dynamic player, Dictionary<string, int> dict, Object enemyName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("Enemy is attacking with {0} and deals {1} damage.", attackName, attackVal);

            player.HP -= attackVal;

            Console.WriteLine("{0}'s HP is at {1}", player.PlayerName, player.HP);
            
        }

    }
}





