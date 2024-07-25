using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Diamante: Alien, Forca, Resistencia
    {
        public Diamante() {
            this.Nome = "Diamante";
            this.Cor = "Esmeralda";
        }
        public void PoderDeForca()
        {
            throw new NotImplementedException();
        }

        public void SuperResistencia()
        {
            throw new NotImplementedException();
        }
    }
}
