using RPG.characters;
using RPG.Items;
using RPG.Items.Armors;
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
            Game g = new Game();
            
            Console.ReadLine();
        }
    }

    class Game
    {           
        public Game()
        {
            Caste Mage = new Caste("Mage",1.1, 1.2, 1.6, 1.2, 1.3, 20, 20, 50, 20, 20);
            Player p = new Player(20, 20,20,20,20,5000, "TuTu", 200, Mage, "male", new Item[] {null, null,null,null, null, null, null, null, null, null, null, null, null,null}, 6.25);
            p.Inventory.Add(new Weapon(2, 20, 20,50,20,20, Mage, 2.5, "Hurkatöltő", 7.2));
            p.Inventory.Add(new Helmet("Sityak", 2 ,20, 20, 50, 20, 20, Mage, 200, 7.2));

            //Console.WriteLine(new Weapon(2, 20, 20, 50, 20, 20, Mage, 2.5, "Hurkatöltő", 7.2).GetType().BaseType);

            Console.WriteLine(p);
            Console.ReadLine();
        }       
    }
}