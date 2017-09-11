using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public class MCØresund : Køretøjer
    {
        
        public MCØresund(string nummerplade, bool broBizz) : base(nummerplade, broBizz)
        {
        }

        public override string Køretøj()
        {
            return "Øresund MC";
        }

        public override int Pris()
        {
            int pris = 210;

            if (BroBizz)
                return pris = 73;

            return pris;
        }
    }
}
