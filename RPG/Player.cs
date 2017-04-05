using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
 
    class Player
    {
        public Random rnd = new Random();
        public string PlayerName { get; set; }
        public int HP { get; set; }

        public void Attack(dynamic enemy, Dictionary<string, int> dict, Object PlayerName)
        {
            var singleAttack = dict.ElementAt(rnd.Next(dict.Count));
            int attackVal = singleAttack.Value;
            string attackName = singleAttack.Key;

            Console.WriteLine("You attack with {0} and deal {1} damage.", attackName, attackVal);

            Console.WriteLine("{0} HP is at {1})", enemy.Name, enemy.PowerLevel);
            enemy.HP -= attackVal;
        }

    }
}
