using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
   internal class FakturaRepository
    {
        internal List<Faktura> fakturor = new List<Faktura>();

        internal void LäggTillFaktura(int bokningsNummer, string medlemsNummer, DateTime faktisktÅterlämningsDatum, double pris)
        {
            fakturor.Add(new Faktura(bokningsNummer, medlemsNummer, faktisktÅterlämningsDatum, pris));
        }
        internal List<Faktura> HämtaFakturor()
        {
            return fakturor;
        }

        public double RäknaUtKostnad(double antalDagar)
        {
            double pris = 0;
            if(antalDagar >= 1)
            {
                pris = antalDagar * 10;
            }
            else
            {
                pris = 0;
            }
            return pris;
        }
    }
 }