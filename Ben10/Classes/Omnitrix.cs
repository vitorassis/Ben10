using Ben10.Classes.Aliens;
using Ben10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Classes
{
    public class Omnitrix
    {
        private Alien[] aliens;

        private int selecionado;

        public bool Transformar(int alien)
        {
            if (aliens == null)
                return false;

            if (aliens.Length <= alien)
                return false;

            selecionado = alien;
            return true;
        }

        public Alien? SelectedAlien
        {
            get
            {
                if (selecionado != -1)
                    return aliens[selecionado];
                return null;
            }
        }


        public int GetAlienIndex(Alien alien)
        {
            int index = 0;
            bool achado = false;
            while (index < aliens.Length && !achado)
            {
                achado = aliens[index].GetType() == alien.GetType();
                if(!achado)
                    index++;
            }

            if (achado)
                return index;
            return -1;
        }

        public bool Destransformar()
        {
            if(selecionado == -1)
                return false;
            selecionado = -1;
            return true;
        }

        public bool Escanear(Alien novoAlien)
        {
            List<Alien> achou = aliens.Where(a => a.Nome == novoAlien.Nome).ToList();
            if(achou.Count == 0)
            {
                aliens[aliens.Length - 1] = novoAlien;
                return true;
            }
            return false;
        }

        public Omnitrix()
        {
            selecionado = -1;

            aliens = new Alien[10];

            aliens[0] = new Chama();
            aliens[1] = new Besta();
            aliens[2] = new Diamante();
            aliens[3] = new XLR8();
            aliens[4] = new MassaCinzenta();
            aliens[5] = new QuatroBracos();
            aliens[6] = new Insectoide();
            aliens[7] = new Aquatico();
            aliens[8] = new UltraT();
            aliens[9] = new Fantasmatico();
        }
    }
}
