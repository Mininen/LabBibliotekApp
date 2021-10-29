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
    public partial class Inloggning : Form
    {
        BusinessManager bm { get; set; }
        public Inloggning(BusinessManager businessManager)
        {
            bm = businessManager;
            InitializeComponent();
            bm.LaddaExpediter();

            felkontroll.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kontroll = false;
            kontroll = bm.LoggaInExpedit(användarnamn.Text, lösen.Text);
            if(kontroll == true)
            {
                Form1 form1 = new Form1(bm);
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
            if(kontroll == false)
            {
                felkontroll.Text = "Fel användarnamn eller lösenord!";
            }
        }

        private void avsluta_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
