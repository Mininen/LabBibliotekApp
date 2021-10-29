using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using affärslager;

namespace Presentationslager
{
    public partial class Form1 : Form
    {
        BusinessManager bm { get; set; }

        public Form1(BusinessManager businessManager)
        {
            bm = businessManager;
            InitializeComponent();
            bm.LaddaBöcker(); 
            bm.LaddaMedlemmar();
            TillgängligaBöcker.DataSource = null;
            medlemsNrLB.DataSource = null;
            LäggTillBöckerIListBox();
            LäggTillMedlemmarIListBox();
        }

        private void avsluta_Click(object sender, EventArgs e)
        {
            Inloggning inloggning = new Inloggning(bm);
            bm.LoggaUtExpedit();
            this.Hide();
            inloggning.ShowDialog();
        }

        private void lånaböcker_Click(object sender, EventArgs e)
        {
            DateTime startDatum = this.startdatumpick.Value.Date;
            DateTime slutDatum = this.slutdatumpick.Value.Date;
            string medlemsNr = (string)medlemsNrLB.SelectedItem;
            string bokTitel = (string)TillgängligaBöcker.SelectedItem;
            bm.LäggTillBokning(medlemsNr, startDatum, slutDatum, bokTitel); 

            Bokningsnummer.Items.Clear();
            LäggTillBokningarIListBox();
            TillgängligaBöcker.Items.Clear();
            LäggTillBöckerIListBox();
        }

        private void visaMedlemsInfo_Click(object sender, EventArgs e)
        {
            string medlemsNR = (string)medlemsNrLB.SelectedItem;
            Medlem valdMedlem = bm.HittaValdMedlem(medlemsNR);
            MessageBox.Show("Namn: " + valdMedlem.Mnamn + " |Medlemsnr: " + valdMedlem.MedlemsNr + " |Tel: " + valdMedlem.TelNr + " |Epost: " + valdMedlem.Epost);
        }

        private void visaBokning_Click(object sender, EventArgs e)
        {
            bokningar.Items.Clear();
            LäggTillBokningarIListBoxVisaBokning();
        }

        private void lämnatillbakaBok_Click(object sender, EventArgs e)
        {
            DateTime återlämningsdatu = this.faktisktÅterlämningsdatum.Value.Date;
            int bokningsNR = (int)Bokningsnummer.SelectedItem;

            bm.LämnaTillbakaBok(återlämningsdatu, bokningsNR); 
            bm.TaBortBokning(bokningsNR);
            
            FakturorListbox.Items.Clear();
            LäggTillFakturorIListBox();

            Bokningsnummer.Items.Clear();
            LäggTillBokningarIListBox();

            TillgängligaBöcker.Items.Clear();
            LäggTillBöckerIListBox();
        }

  
        public void LäggTillBöckerIListBox()
        {
            List<Bok> bokLista = bm.HämtaLedigaBöcker();
            foreach (Bok b in bokLista)
            {
                TillgängligaBöcker.Items.Add(b.Titel);
            }
        }

        public void LäggTillMedlemmarIListBox()
        {
            List<Medlem> medlemsNrLista = bm.HämtaMedlem();
            foreach (Medlem m in medlemsNrLista)
            {
                medlemsNrLB.Items.Add(m.MedlemsNr);
            }
        }

        public void LäggTillBokningarIListBox()
        {
            List<Bokning> bokningsNrLista = bm.HämtaBokningar();
            foreach (Bokning b in bokningsNrLista)
            {
                Bokningsnummer.Items.Add(b.BokningsNr);
            }
        }

        public void LäggTillBokningarIListBoxVisaBokning()
        {
            List<Bokning> bokningsNrLista = bm.HämtaBokningar();
            foreach (Bokning b in bokningsNrLista)
            {
                bokningar.Items.Add(b.BokningsNr + " : " + b.StartDatum + " : " + b.SlutDatum + " : " + b.MedlemsNr + " : " + b.ExpeditNr);
            }
        }

        public void LäggTillFakturorIListBox()
        {
            List<Faktura> FakturaLista = bm.HämtaFakturor();
            foreach (Faktura f in FakturaLista)
            {
                FakturorListbox.Items.Add(f.BokningsNummer + " : " + f.Pris + " : " + f.MedlemsNummer);
            }
        }
    }
}

