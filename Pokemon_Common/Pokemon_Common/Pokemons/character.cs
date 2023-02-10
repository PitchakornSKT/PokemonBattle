using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Common.Pokemons
{
    internal class character
    {
        protected string name;
        public int charNum;
        public double atk;
        public double hp = 100;
        public Bitmap _image;

        

        public Bitmap getImage()
        {
            return _image;
        }

        public string getName()
        {
            return this.name;
        }

        public double getHP()
        {
            return this.hp;
        }

        public double getAtk()
        {
            return this.atk;
        }


        public void takeDamge(int dam, int acc )
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 21);
            
            
            if (roll >= acc)
            {
                if (roll == 20)
                {
                    hp -=  dam * 1.5;
                }
                else
                {
                    hp -=  dam;
                }
            }

        }
    }
}
