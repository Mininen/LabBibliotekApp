using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace affärslager
{
    public class BusinessManager
    {
        internal BokningRepository BokningRepo { get; set; } 
        internal BokRepository BokRepo { get; set; }
        internal ExpeditRepository ExpeditRepo { get; set; }
        internal FakturaRepository FakturaRepo { get; set; }
        internal MedlemRepository MedlemRepo { get; set; }

        public BusinessManager()
        {
            BokningRepo = new BokningRepository();
            BokRepo = new BokRepository();
            ExpeditRepo = new ExpeditRepository();
            FakturaRepo = new FakturaRepository();
            MedlemRepo = new MedlemRepository();
        }

        //Medlem 
        public List<Medlem> HämtaMedlem()
        {
            return MedlemRepo.HämtaMedlem();
        }

        public void LaddaMedlemmar()
        {
            MedlemRepo.LaddaMedlemmar();
        }

        public Medlem HittaValdMedlem(string id)
        {
            return MedlemRepo.HittaValdMedlem(id);
        }

        //Faktura 
        public List<Faktura> HämtaFakturor()
        {
            return FakturaRepo.HämtaFakturor();
        }

        //Expedit 
        public bool LoggaInExpedit(string användarnamn, string lösen)
        {
            return ExpeditRepo.LoggaInExpedit(användarnamn, lösen);
        }

        public void LaddaExpediter()
        {
            ExpeditRepo.LaddaExpediter();
        }

        public void LoggaUtExpedit()
        {
            ExpeditRepo.LoggaUtExpedit();
        }

        public void LaddaBöcker()
        {
            BokRepo.LaddaBöcker();
        }

        public List<Bok> HämtaLedigaBöcker()
        {
            return BokRepo.HämtaLedigaBöcker();
        }

        //Lämna tillbaka bok
        public void LämnaTillbakaBok(DateTime återlämningsDatum, int bokningsNr)
        {
            string medlemsNummerB = BokningRepo.HittaMedlemIBokning(bokningsNr);
            string bokadBokTitel = BokningRepo.HittaBokadBok(bokningsNr);
            double antalDagar = BokningRepo.RäknaUtAntaldagar(bokningsNr, återlämningsDatum);

            BokRepo.GörBokadTillFalse(bokadBokTitel); 

            double pris = FakturaRepo.RäknaUtKostnad(antalDagar);

            FakturaRepo.LäggTillFaktura(bokningsNr, medlemsNummerB, återlämningsDatum, pris);
        }

        //Bokning 
        public void LäggTillBokning(string medlemsNr, DateTime startdatum, DateTime slutdatum, string bokTitel)
        {
            string expeditNr = ExpeditRepo.HittaInloggadExpeditNR();
            BokningRepo.LäggTillBokning(medlemsNr, startdatum, slutdatum, bokTitel, expeditNr);
            BokRepo.GörBokadTillTrue(bokTitel);
        }
        public List<Bokning> HämtaBokningar()
        {
            return BokningRepo.HämtaBokningar();
        }

        public void TaBortBokning(int bokningsNR)
        {
            BokningRepo.TaBortBokning(bokningsNR);
        }
    }
}
