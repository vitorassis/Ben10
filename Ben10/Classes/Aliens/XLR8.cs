using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class XLR8 : Alien, Velocidade
    {
        public XLR8()
        {
            this.Nome = "XLR8";
            this.Cor = "Preto e Azul";
        }

        public void Reflexos()
        {
            throw new NotImplementedException();
        }

        public void SuperVelocidade()
        {
            throw new NotImplementedException();
        }

        public void Vigor()
        {
            throw new NotImplementedException();
        }
    }
}
