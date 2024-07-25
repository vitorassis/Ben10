using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Fantasmatico : Alien, Fantasma
    {
        public Fantasmatico() {
            this.Nome = "Fantasmático";
            this.Cor = "Cinza e Preto";
        }
        public void PoderFantasma()
        {
            throw new NotImplementedException();
        }
    }
}
