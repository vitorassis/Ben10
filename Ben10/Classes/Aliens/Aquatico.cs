using Ben10.Classes.Interfaces;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes.Aliens
{
    public class Aquatico : Alien, Velocidade, Interfaces.Aquatico, Forca
    {
        public Aquatico() {
            this.Nome = "Aquatico";
            this.Cor = "Branco e Verde";
        }

        public void PoderAquatico()
        {
            throw new NotImplementedException();
        }

        public void PoderDeForca()
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
