using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class Expedit
    {
        internal string AnställningsNr { get; set; }
        internal string Anamn { get; set; }
        internal string AnvändarNamn { get; set; }
        internal string Lösen { get; set; }
        internal bool Inloggad { get; set; }

        internal Expedit(string anställningsNr, string anamn, string användarnamn, string lösen)
        {
            AnställningsNr = anställningsNr;
            Anamn = anamn;
            AnvändarNamn = användarnamn;
            Lösen = lösen;
            Inloggad = false;
        }

        internal bool InloggsKontroll(string användarnamn, string lösen)
        {
            bool kontroll;
            if(användarnamn == this.AnvändarNamn && lösen == this.Lösen)
            {
                kontroll = true;
                Inloggad = true;
            }
            else
            {
                kontroll = false;
            }
            return kontroll;
        }
    }
}
