using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public class MC : Køretøjer
    {
        
        public MC(string nummerplade, bool broBizz)
            : base(nummerplade, broBizz)
        {

        }

        
        public override int Pris()
        {
            int pris = 125;

            if (BroBizz)
                return pris * 95 / 100;

            return pris;
        }

        
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
