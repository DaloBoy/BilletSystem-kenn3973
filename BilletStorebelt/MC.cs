using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt
{
    public class MC : Køretøjer
    {
        public MC(string nummerplade)
            : base(nummerplade)
        {
            
        }

        public override int Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}
