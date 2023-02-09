using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Common.Pokemons
{
    internal class charizard : character
    {
        public charizard()
        {
            this.name = "Charizard";
            Random random = new Random();
            this._image = Properties.Resources._6;
            this.hp = 360;
            this.atk = random.Next(155, 293);
        }
    }
}
