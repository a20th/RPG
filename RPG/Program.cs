using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game(3000);
            
            Console.ReadLine();
        }
    }

    class Game
    {
        private int xp;
        string[] Slots = { "Head", "Chestpiece", "Leg", "Foot", "Weapon1", "Weapon2", "Ring1", "Ring2", "Trinket1", "Trinket2" };
        public Game(int xp)
        {
            this.xp = xp;
        }

        //public int Level { get => calculateLevel(xp, 1); }
        /*private int calculateLevel(int xpmod, int lvl)
        {
            if(xpmod >= 400 + (lvl - 1) * 500){
                Console.WriteLine("ret1");
                return calculateLevel(xpmod - 400 + (lvl - 1) * 500, ++lvl);
            }
            else{
                Console.WriteLine("ret2");
                return lvl;
            }
        }*/

        /*private int calculateLevel()
        {
            int xpmod = xp;
            int lvl = 1;
            while(xpmod >= 400 + (lvl - 1) * 500)
            {
                xpmod -= 400 + (lvl - 1) * 500;
                lvl++;
            }
            return lvl;
        }*/
    }
}


