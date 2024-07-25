using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ben10.Models
{
    public abstract class Alien
    {
        public string Nome;
        public string Cor;

        override
        public string ToString()
        {  return Nome; }
    }
}
