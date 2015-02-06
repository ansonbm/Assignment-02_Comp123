/*Created by :AnsonBaby
 * Lastmodified: 6th Feb 2015
 * Program description: Program entry point 
 * Revision History: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_Comp123_AnsonBaby
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero heroMan = new Hero("hero Man");//new object
            heroMan.show();// call the show method to display the abilities
            heroMan.fight();// call the fight method from the hero class

            SuperHero superHeroMan = new SuperHero("super Hero Man");
            superHeroMan.showPowers();
            superHeroMan.fight();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();//wait for an entry to exit 
        }
    }
}
