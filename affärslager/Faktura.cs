using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class Faktura
    {
        public int BokningsNummer { get; internal set; }
        public string MedlemsNummer { get; internal set; }
        public DateTime FaktisktÅterlämningsDatum { get; internal set; }
        public double Pris { get; internal set; }
        internal Faktura(int bokningsNummer, string medlemsNummer, DateTime faktisktÅterlämningsDatum, double pris)
        {
            BokningsNummer = bokningsNummer;
            MedlemsNummer = medlemsNummer;
            FaktisktÅterlämningsDatum = faktisktÅterlämningsDatum;
            Pris = pris;
        }
    }
}
