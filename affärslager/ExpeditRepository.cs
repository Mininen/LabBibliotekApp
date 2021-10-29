using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    internal class ExpeditRepository
    {
        internal List<Expedit> expediter = new List<Expedit>();
        internal void LäggTillExpedit(string anställningsNr, string anamn, string användarnamn, string lösen)
        {
            expediter.Add(new Expedit(anställningsNr, anamn, användarnamn, lösen));
        }

        internal void LaddaExpediter()
        {
            if(HämtaExpediter().Count() == 0)
            {
                LäggTillExpedit("1", "Lisa", "Lisa1", "Lisa1");
                LäggTillExpedit("2", "Albert", "Albert2", "Albert2");
            }
        }

        internal List<Expedit> HämtaExpediter()
        {
            return expediter;
        }

        internal bool LoggaInExpedit(string användarnamn, string lösen)
        {
            bool kontroll = false;
            for(int i = 0; i < expediter.Count; i++)
            {
                kontroll = expediter[i].InloggsKontroll(användarnamn, lösen);
                if(kontroll == true)
                {
                    kontroll = true;
                    return kontroll;
                }
            }
            return kontroll;
        }

        internal string HittaInloggadExpeditNR()
        {
            string expeditNr = null;
            foreach (Expedit expedit in expediter)
            {
                if (expedit.Inloggad == true)
                {
                    expeditNr = expedit.AnställningsNr;
                }
            }

            return expeditNr;
        }

        internal void LoggaUtExpedit()
        {
            foreach (Expedit expedit in expediter)
            {
                if (expedit.Inloggad == true)
                {
                    expedit.Inloggad = false;
                }
            }
        }
    }
}
