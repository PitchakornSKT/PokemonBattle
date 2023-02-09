using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Common.Pokemons
{
    internal class ceruledge : character
    {
        public ceruledge() 
        {
            this.name = "Ceruledge";
            Random random = new Random();
            this._image = Properties.Resources._937;
            this.hp = 354;
            this.atk = random.Next(229, 383);
        }
    }
}
