using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class UltraT : Alien, Tecnologico, Resistencia
    {
        public UltraT() {
            this.Nome = "Ultra T";
            this.Cor = "Verde, Branco e Preto";
        }
        public void PoderTecnologico()
        {
            throw new NotImplementedException();
        }

        public void SuperResistencia()
        {
            throw new NotImplementedException();
        }
    }
}
