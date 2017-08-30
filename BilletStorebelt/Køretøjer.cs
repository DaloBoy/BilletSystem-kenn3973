using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public abstract class Køretøjer
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public Køretøjer(string nummerplade)
        {
            this.Nummerplade = nummerplade;
        }

        public abstract int Pris();

        public abstract string Køretøj();
    }
}
