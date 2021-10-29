using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    internal class BokningRepository
    {
        internal List<Bokning> bokningar = new List<Bokning>();

        internal void LäggTillBokning(string medlemsNr, DateTime startdatum, DateTime slutdatum, string bokTitel, string expeditNr)
        {
            bokningar.Add(new Bokning(medlemsNr, startdatum, slutdatum, bokTitel, expeditNr));
        }
        internal List<Bokning> HämtaBokningar()
        {
            return bokningar;
        }

        internal void TaBortBokning(int bokningsNR)
        {
            for (int i = 0; i < bokningar.Count(); i++)
            { 
                if(bokningar[i].BokningsNr == bokningsNR)
                {
                    bokningar.RemoveAt(i);
                }
            }
        }

        internal string HittaMedlemIBokning(int bokningsID)
        {
            string medlemsNummer = null;
            foreach (Bokning bokning in bokningar) 
            {
                if (bokning.BokningsNr == bokningsID) 
                {
                    medlemsNummer = bokning.MedlemsNr;
                }
            }
            return medlemsNummer;
        }

        internal string HittaBokadBok(int bokningsID)
        {
            string bokadBokTitel = null;
            foreach(Bokning bokning in bokningar)
            {
                if(bokning.BokningsNr == bokningsID)
                {
                    bokadBokTitel = bokning.Boktitel;
                }
            }

            return bokadBokTitel;
        }

        public double RäknaUtAntaldagar(int bokningNr, DateTime fåterlämningsdatum)
        {
            double antalDagar = 0;
            foreach (Bokning bokning in bokningar)
            {
                if (bokning.BokningsNr == bokningNr)
                {
                    antalDagar = (fåterlämningsdatum - bokning.SlutDatum).TotalDays;
                }
            }
            return antalDagar;
        }
    }
}
