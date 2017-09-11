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
        public bool BroBizz { get; set; }

        
        public Køretøjer(string nummerplade, bool broBizz)
        {
            this.Nummerplade = nummerplade;
            this.BroBizz = broBizz;
        }

        
        public abstract int Pris();

        public abstract string Køretøj();

        public virtual int NummerpladeLænge()
        {
            if (Nummerplade.Length > 7  )
            {
                throw new ArgumentException("Nummerplade er for lang");
            }
            return Nummerplade.Length;
        }
    }
}
