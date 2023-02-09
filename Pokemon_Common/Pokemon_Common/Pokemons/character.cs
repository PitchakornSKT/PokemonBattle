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
        public int atk;
        public int hp;
        public Bitmap _image;

        public character() 
        { 
        
        }

        public Bitmap getImage()
        {
            return _image;
        }

        public string getName()
        {
            return this.name;
        }

        public int getHP()
        {
            return this.hp;
        }
        public void takeDamge(int dam)
        {
            this.hp -= dam;
        }
    }
}
