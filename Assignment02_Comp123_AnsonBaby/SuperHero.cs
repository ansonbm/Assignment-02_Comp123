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
    class SuperHero:Hero
    {
        string[] superPowers;
        public SuperHero(string name):base(name)
        {
            generateAbilities();
        }

        private void generateAbilities()
        {
            string[] allPowers = new string[] { "Super Speed", "Super Strength", "Body Armour", "Flight", "Fire Generation", "Weather Control" };
            superPowers = new string[3];
            string newValue;
            int counter = 0;
            do
            {
                newValue = allPowers[rnd.Next(0, allPowers.Length - 1)];
                if (!superPowers.Contains(newValue))
                {
                    superPowers[counter] = newValue;
                    counter++;
                }
            }
            while (counter < superPowers.Length);
        }


        public void showPowers()
        {
            for (int i = 0; i < superPowers.Length; i++)
            {
                Console.WriteLine("Super power: {0}", superPowers[i]);
            }
        }
    }
}
