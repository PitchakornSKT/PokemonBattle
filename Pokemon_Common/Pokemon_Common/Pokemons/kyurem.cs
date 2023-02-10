using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Common.Pokemons
{
    internal class kyurem : character
    {
        public kyurem()
        {
            this.name = "Kyurem";
            Random random = new Random();
            this._image = Properties.Resources._4070;
            
        }
    }
}
