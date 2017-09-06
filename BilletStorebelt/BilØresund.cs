using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public class BilØresund : Køretøjer
    {
        public BilØresund(string nummerplade, bool broBizz) : base(nummerplade, broBizz)
        {
        }

        public override string Køretøj()
        {
            return "Øresund Bil";
        }

        public override int Pris()
        {
            int pris = 410;

            if (BroBizz)
                return pris = 161;

            return pris;
        }
    }
}
