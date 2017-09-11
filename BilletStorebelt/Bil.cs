using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public class Bil : Køretøjer
    {
       
        public Bil(string nummerplade, bool broBizz)
            : base(nummerplade, broBizz)
        {

        }

        
        public override int Pris()
        {
            int pris = 240;

            if (base.Dato.DayOfWeek == DayOfWeek.Saturday || base.Dato.DayOfWeek == DayOfWeek.Sunday)
                pris = pris * 80 / 100;

            if (BroBizz)
                return pris * 95 / 100;

            return pris;
        }
        
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
