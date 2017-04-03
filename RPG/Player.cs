using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public enum CharacterClass
    {
        Warrior = 0,
        Hunter = 1,
        Mage = 2

    }

    class Player
    {
        public string PlayerName { get; set; }
        public CharacterClass Class { get; set; }
        public int HP { get; set; }



        public Player(string name, CharacterClass cs)
        {
            this.PlayerName = name;
            this.Class = cs;

        }

        public CharacterClass ChooseClass(int t)
        {
            switch (t)
            {
                case 0:
                    Console.WriteLine("You are a warrior.");
                    return this.Class = CharacterClass.Warrior;

                case 1:
                    Console.WriteLine("You are a hunter");
                    return this.Class = CharacterClass.Hunter;

                case 2:
                    Console.WriteLine("You are a mage.");
                    return this.Class = CharacterClass.Mage;

                default:
                    Console.WriteLine("You did not select a class, you have been assigned warrior.");
                    return this.Class = CharacterClass.Warrior;

            }
        }



    }
}
