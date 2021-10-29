using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class Bokning
    {
        public string MedlemsNr { get; internal set; }
        public DateTime StartDatum { get; internal set; }
        public DateTime SlutDatum { get; internal set; }
        public int BokningsNr { get; internal set; }
        public string Boktitel { get; internal set; }
        public string ExpeditNr { get; internal set; }

        private readonly Random rdn = new Random();

        internal Bokning(string medlemsNr, DateTime startdatum, DateTime slutdatum, string bokTitel, string expeditNr)
        {
            MedlemsNr = medlemsNr;
            StartDatum = startdatum;
            SlutDatum = slutdatum;
            BokningsNr = rdn.Next();
            Boktitel = bokTitel;
            ExpeditNr = expeditNr;
        }
    }
}
