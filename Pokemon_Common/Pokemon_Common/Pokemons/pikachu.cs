using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Common.Pokemons
{
    internal class pikachu : character
    {
        public pikachu() 
        {
            this.name = "Pikachu";
            Random random = new Random();
            this._image = Properties.Resources._25;
            
        }
    }
}
