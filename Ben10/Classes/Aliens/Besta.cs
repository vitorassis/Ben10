using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Besta : Alien, Forca, Velocidade
    {
        public Besta() {
            this.Nome = "Besta";
            this.Cor = "Laranja";
        }

        public void PoderDeForca()
        {
            throw new NotImplementedException();
        }

        public void PoderVeloz()
        {
            throw new NotImplementedException();
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
