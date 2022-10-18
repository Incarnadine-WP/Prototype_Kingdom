using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Kingdom
{
    

        class Champ
        {
            string name;
            public int hp_her;
            public int hp_en;
            public int dmg_en;
            public int Cur_hp_her;
            public int Cur_hp_en;
          //  float exp = 0f;
            public int mana;
            string FavoriteSpell;
            static Random ran = new Random();
            int dmg;
          //  int hello;



            public Champ(string _class, string fs)
            {
                name = _class;
                FavoriteSpell = fs;
            }

            public void UseSpell_Mage()
            {
                dmg = ran.Next(100, 150);

                if (mana > 99)
                {
                    Console.WriteLine(name + " use " + FavoriteSpell + " and deal: " + dmg);
                    mana -= 100;

                }
                else Console.WriteLine("not enough mana: " + mana);
            }

            public void Mage_Fight()
            {
                hp_her = 250;
                hp_en = 150;
                dmg = ran.Next(100, 150);
                dmg_en = ran.Next(20, 31);

                if (mana > 99)
                {
                    Console.WriteLine(name + " use " + FavoriteSpell + " and deal: " + dmg + " to Skeleton");
                    Console.WriteLine("Skeleton deal you " + dmg_en);
                    mana -= 100;


                }
                else Console.WriteLine("Not enough mana");

                if (Cur_hp_en > 0 && Cur_hp_her > 0)
                {
                    Cur_hp_her = hp_her - dmg_en;
                    Cur_hp_en = hp_en - dmg;
                    Console.WriteLine(name + " had: " + Cur_hp_her);
                    Console.WriteLine("Skeleton had: " + Cur_hp_en);
                }
                else if (Cur_hp_her <= 0) Console.WriteLine("You died");
                else if (Cur_hp_en <= 0) Console.WriteLine("Skeleton defeated!");

            }

        static int AnsOpt(int numb)
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isInRange = int.TryParse(input, out number);
            bool option = number >= 1 && number <= numb;

            while(!isInRange || !option)
            {
                Console.WriteLine("Выберете доступное действие:");
                 input = Console.ReadLine();
                 isInRange = int.TryParse(input, out numb);
                 option = number >= 1 && number <= numb;
            }
            return number;
        }
        

        }

        class Enemy
        {
            string Name;
            public int hp;
            int en_dmg;
            static Random en_ran = new Random();
            float exp = 0f;

            public void Hit_Enemy(string _name)
            {
                Name = _name;
                en_dmg = en_ran.Next(20, 31);
                hp = 300;
                if (hp > 0) Console.Write(Name + " hit you for " + en_dmg + " ");
                else Console.WriteLine("You kill " + Name + " and received ");
                {
                    exp += 68;
                }

            }

        }
    
        class Kingdom
        {
            static void Main(string[] args)
            {

                Console.Write("Hello stranger! Welcome to the Kingdom.\nStranger: ");
                string _hello = Console.ReadLine();
                Console.WriteLine("What is your name?");
                string Hero_name = Console.ReadLine();
                Console.WriteLine("Okey " + Hero_name + ", I have bad news, the kingdom has been attacked by the walking Dead!\n" +
                    "And we need your help... we need a Hero to fight the darkness, what specialization will you choose?");
                Console.WriteLine("1) Archer;\n2) Warrior;\n3) Mage");
                Console.WriteLine("To know more about each class write \"info\"");

                bool fight = true;

                while (fight)
                {
                    fight = false;
                    Console.ReadKey();
                }

                Champ Mage = new Champ("Mage", "Fire-ball");
                Mage.mana = 300;
                Mage.hp_her = 250;

                Enemy Skeleton = new Enemy();
                Skeleton.Hit_Enemy("skeleton");


                Champ Warrior = new Champ("Warrior", "Shild-stun");
                Warrior.mana = 150;
                Warrior.hp_her = 500;




                // Warrior.UseSpell_Warrior();

                // Mage.UseSpell_Mage();
                // Console.ReadKey();
                // Mage.UseSpell_Mage();
                // Console.ReadKey();

                //  Mage.UseSpell_Mage();
                //  Console.ReadKey();
                //  Mage.UseSpell_Mage();



                Console.ReadKey();


            }
        }
}
