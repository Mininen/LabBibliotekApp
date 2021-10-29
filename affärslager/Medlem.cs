using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class Medlem
    {
        public string MedlemsNr { get; internal set; }
        public string Mnamn { get; internal set; }
        public string TelNr { get; internal set; }
        public string Epost { get; internal set; }

        internal Medlem(string medlemsNr, string mNamn, string telNr, string epost)
        {
            MedlemsNr = medlemsNr;
            Mnamn = mNamn;
            TelNr = telNr;
            Epost = epost;
        }
    }
}
