using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Insectoide : Alien, Voo
    {
        public Insectoide() {
            this.Nome = "Insectóide";
            this.Cor = "Verde";
        }
        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
