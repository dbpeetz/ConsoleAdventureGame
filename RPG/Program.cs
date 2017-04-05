using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{

    class Program
    {
        public static Mage mage;
        public static Hunter hunter;
        public static Warrior warrior;
        static void Main(string[] args)
        {
            Console.Title = "Castlemark Tower";
            int choice = 0;
            int classChoice;
            string playerName;

          do
            {
                MainTitle();
                Console.WriteLine();
                playerName = NameMenu();
                classChoice = ClassMenu();
                choice = MainMenu();



               if (choice == 1 )
               {
                    Dragon drg = new Dragon();
                    
                    if (classChoice == 1)
                    {
                        mage = new Mage(playerName);
                        Console.WriteLine("You have encountered an Obsidian Drake");
                        while (mage.HP >= 1 && drg.PowerLevel >= 1)
                        {                          
                            mage.MageAttack(drg);
                            drg.DragonAttack(mage);
                            if (mage.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (drg.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the dragon.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();



                    }
                    if (classChoice == 2)
                    {
                        warrior = new Warrior(playerName);
                        Console.WriteLine("You have encountered an Obsidian Drake");
                        while (warrior.HP >= 1 && drg.PowerLevel >= 1)
                        {
                            warrior.WarAttack(drg);
                            drg.DragonAttack(warrior);
                            if (warrior.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (drg.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the dragon.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                    }
                    if (classChoice == 3)
                    {
                        hunter = new Hunter(playerName);
                        Console.WriteLine("You have encountered an Obsidian Drake");
                        while (hunter.HP >= 1 && drg.PowerLevel >= 1)
                        {
                            hunter.HuntAttack(drg);
                            drg.DragonAttack(hunter);
                            if (hunter.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (drg.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the dragon.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                    }
                }
                if (choice == 2)
                {
                    Leviathan lev = new Leviathan();

                    if (classChoice == 1)
                    {
                        mage = new Mage(playerName);
                        Console.WriteLine("You have encountered a Leviathan");
                        while (mage.HP >= 1 && lev.PowerLevel >= 1)
                        {
                            mage.MageAttack(lev);
                            lev.LeviathanAttack(mage);
                            if (mage.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (lev.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the Leviathan.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();



                    }
                    if (classChoice == 2)
                    {
                        warrior = new Warrior(playerName);
                        Console.WriteLine("You have encountered a Leviathan");
                        while (warrior.HP >= 1 && lev.PowerLevel >= 1)
                        {
                            warrior.WarAttack(lev);
                            lev.LeviathanAttack(warrior);
                            if (warrior.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (lev.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the Leviathan.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();
                    }
                    if (classChoice == 3)
                    {
                        hunter = new Hunter(playerName);
                        Console.WriteLine("You have encountered a Leviathan");
                        while (hunter.HP >= 1 && lev.PowerLevel >= 1)
                        {
                            hunter.HuntAttack(lev);
                            lev.LeviathanAttack(hunter);
                            if (hunter.HP <= 0)
                            {
                                Console.WriteLine("You have been defeated.");
                            }
                            else if (lev.PowerLevel <= 0)
                            {
                                Console.WriteLine("Congratulations! You have defeated the Leviathan.");
                                Console.ReadLine();
                            }


                        }

                        Console.WriteLine("Game Over");
                        Console.ReadLine();

                    }
                }


                } while (choice != 3);

 

            //create 3 different class choices

            //Create attacks that change based on user input

            //creat menu to select which enemy they will fight
            //Create attack methods that randomly generate attacks for enemies
            //Create menu to select which attack the player wants to use.


            Console.ReadLine();
        }

        private static void MainTitle()
        {
            Console.Clear();
            string title = (@"
 _____           _   _                           _      _____                      
/  __ \         | | | |                         | |    |_   _|                     
| /  \/ __ _ ___| |_| | ___ _ __ ___   __ _ _ __| | __   | | _____      _____ _ __ 
| |    / _` / __| __| |/ _ \ '_ ` _ \ / _` | '__| |/ /   | |/ _ \ \ /\ / / _ \ '__|
| \__/\ (_| \__ \ |_| |  __/ | | | | | (_| | |  |   <    | | (_) \ V  V /  __/ |   
 \____/\__,_|___/\__|_|\___|_| |_| |_|\__,_|_|  |_|\_\   \_/\___/ \_/\_/ \___|_|   
                                                                                   
                                                                                   ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(title);
        }
        private static int MainMenu()
        {
            int choice;           
            Console.ForegroundColor = ConsoleColor.DarkYellow;


            Console.WriteLine("Upon entering you have two choices.\n" +
                "Stairs leading up, or a rope leading down below.");
            Console.WriteLine("Which do you choose?");
            Console.WriteLine("*********************");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Option 1: Stairs");
            Console.WriteLine("Option 2: Basement");
            Console.WriteLine("Option 3: Quit");

            choice = Int32.Parse(Console.ReadLine());
            return choice;
           

        }

        private static int ClassMenu()
        {
            int classChoice;
            Console.WriteLine("Please choose a class");
            Console.WriteLine("1:Mage");
            Console.WriteLine("2:Warrior");
            Console.WriteLine("3:Hunter");
            Console.WriteLine("*********************");
            classChoice = Int32.Parse(Console.ReadLine());
            return classChoice;
        }

        private static string NameMenu()
        {
            string playerName;
            Console.WriteLine("Welcome to Castlemark Tower\n");
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            return playerName;
        }
    }
}
