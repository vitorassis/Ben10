using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class MassaCinzenta: Alien, Inteligencia
    {
        public MassaCinzenta()
        {
            this.Nome = "Massa Cinzenta";
            this.Cor = "Cinza";
        }

        public void SuperInteligencia()
        {
            throw new NotImplementedException();
        }
    }
}
