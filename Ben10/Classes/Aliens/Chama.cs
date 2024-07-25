using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Chama : Alien, Fogo
    {

        public Chama() {
            this.Nome = "Chama";
            this.Cor = "Laranja, Vermelho e Marrom";
        }

        public void PoderDeFogo()
        {
            throw new NotImplementedException();
        }
    }
}
