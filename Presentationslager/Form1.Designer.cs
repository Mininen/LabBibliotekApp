namespace Presentationslager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TillgängligaBöcker = new System.Windows.Forms.ListBox();
            this.lånaböcker = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lämnatillbakaBok = new System.Windows.Forms.Button();
            this.avsluta = new System.Windows.Forms.Button();
            this.medlemsNrLB = new System.Windows.Forms.ListBox();
            this.startdatumpick = new System.Windows.Forms.DateTimePicker();
            this.slutdatumpick = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bokningsnummer = new System.Windows.Forms.ListBox();
            this.faktisktÅterlämningsdatum = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.FakturorListbox = new System.Windows.Forms.ListBox();
            this.visaBokning = new System.Windows.Forms.Button();
            this.bokningar = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.visaMedlemsInfo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj bok att låna:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Välj medlemnsnr:";
            // 
            // TillgängligaBöcker
            // 
            this.TillgängligaBöcker.FormattingEnabled = true;
            this.TillgängligaBöcker.ItemHeight = 20;
            this.TillgängligaBöcker.Location = new System.Drawing.Point(14, 34);
            this.TillgängligaBöcker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TillgängligaBöcker.Name = "TillgängligaBöcker";
            this.TillgängligaBöcker.Size = new System.Drawing.Size(262, 304);
            this.TillgängligaBöcker.TabIndex = 2;
            // 
            // lånaböcker
            // 
            this.lånaböcker.Location = new System.Drawing.Point(307, 258);
            this.lånaböcker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lånaböcker.Name = "lånaböcker";
            this.lånaböcker.Size = new System.Drawing.Size(199, 34);
            this.lånaböcker.TabIndex = 4;
            this.lånaböcker.Text = "Låna bok";
            this.lånaböcker.UseVisualStyleBackColor = true;
            this.lånaböcker.Click += new System.EventHandler(this.lånaböcker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1409, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Välj bokningsnr:";
            // 
            // lämnatillbakaBok
            // 
            this.lämnatillbakaBok.Location = new System.Drawing.Point(701, 82);
            this.lämnatillbakaBok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lämnatillbakaBok.Name = "lämnatillbakaBok";
            this.lämnatillbakaBok.Size = new System.Drawing.Size(201, 34);
            this.lämnatillbakaBok.TabIndex = 8;
            this.lämnatillbakaBok.Text = "Återlämna bok";
            this.lämnatillbakaBok.UseVisualStyleBackColor = true;
            this.lämnatillbakaBok.Click += new System.EventHandler(this.lämnatillbakaBok_Click);
            // 
            // avsluta
            // 
            this.avsluta.Location = new System.Drawing.Point(1113, 508);
            this.avsluta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(179, 45);
            this.avsluta.TabIndex = 10;
            this.avsluta.Text = "Logga ut";
            this.avsluta.UseVisualStyleBackColor = true;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // medlemsNrLB
            // 
            this.medlemsNrLB.FormattingEnabled = true;
            this.medlemsNrLB.ItemHeight = 20;
            this.medlemsNrLB.Location = new System.Drawing.Point(307, 34);
            this.medlemsNrLB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medlemsNrLB.Name = "medlemsNrLB";
            this.medlemsNrLB.Size = new System.Drawing.Size(201, 104);
            this.medlemsNrLB.TabIndex = 11;
            // 
            // startdatumpick
            // 
            this.startdatumpick.Location = new System.Drawing.Point(307, 168);
            this.startdatumpick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startdatumpick.Name = "startdatumpick";
            this.startdatumpick.Size = new System.Drawing.Size(201, 26);
            this.startdatumpick.TabIndex = 12;
            // 
            // slutdatumpick
            // 
            this.slutdatumpick.Location = new System.Drawing.Point(307, 218);
            this.slutdatumpick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.slutdatumpick.Name = "slutdatumpick";
            this.slutdatumpick.Size = new System.Drawing.Size(201, 26);
            this.slutdatumpick.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Startdatum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Slutdatum:";
            // 
            // Bokningsnummer
            // 
            this.Bokningsnummer.FormattingEnabled = true;
            this.Bokningsnummer.ItemHeight = 20;
            this.Bokningsnummer.Location = new System.Drawing.Point(555, 34);
            this.Bokningsnummer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bokningsnummer.Name = "Bokningsnummer";
            this.Bokningsnummer.Size = new System.Drawing.Size(116, 304);
            this.Bokningsnummer.TabIndex = 16;
            // 
            // faktisktÅterlämningsdatum
            // 
            this.faktisktÅterlämningsdatum.Location = new System.Drawing.Point(701, 34);
            this.faktisktÅterlämningsdatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.faktisktÅterlämningsdatum.Name = "faktisktÅterlämningsdatum";
            this.faktisktÅterlämningsdatum.Size = new System.Drawing.Size(201, 26);
            this.faktisktÅterlämningsdatum.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Återlämningsdatum:";
            // 
            // FakturorListbox
            // 
            this.FakturorListbox.FormattingEnabled = true;
            this.FakturorListbox.ItemHeight = 20;
            this.FakturorListbox.Location = new System.Drawing.Point(18, 429);
            this.FakturorListbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FakturorListbox.Name = "FakturorListbox";
            this.FakturorListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.FakturorListbox.Size = new System.Drawing.Size(262, 124);
            this.FakturorListbox.TabIndex = 19;
            // 
            // visaBokning
            // 
            this.visaBokning.Location = new System.Drawing.Point(701, 138);
            this.visaBokning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visaBokning.Name = "visaBokning";
            this.visaBokning.Size = new System.Drawing.Size(201, 34);
            this.visaBokning.TabIndex = 21;
            this.visaBokning.Text = "Visa pågående bokningar";
            this.visaBokning.UseVisualStyleBackColor = true;
            this.visaBokning.Click += new System.EventHandler(this.visaBokning_Click);
            // 
            // bokningar
            // 
            this.bokningar.FormattingEnabled = true;
            this.bokningar.ItemHeight = 20;
            this.bokningar.Location = new System.Drawing.Point(924, 54);
            this.bokningar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bokningar.Name = "bokningar";
            this.bokningar.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.bokningar.Size = new System.Drawing.Size(524, 284);
            this.bokningar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(920, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bokningar:";
            // 
            // visaMedlemsInfo
            // 
            this.visaMedlemsInfo.Location = new System.Drawing.Point(307, 304);
            this.visaMedlemsInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.visaMedlemsInfo.Name = "visaMedlemsInfo";
            this.visaMedlemsInfo.Size = new System.Drawing.Size(199, 34);
            this.visaMedlemsInfo.TabIndex = 24;
            this.visaMedlemsInfo.Text = "Visa medlemsinfo";
            this.visaMedlemsInfo.UseVisualStyleBackColor = true;
            this.visaMedlemsInfo.Click += new System.EventHandler(this.visaMedlemsInfo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(920, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(455, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Bokningsnr:   Startdatum:   Slutdatum:   Medlemsnr:   Expeditnr:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fakturor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 404);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Bokningsnr:   Pris:   Medlemsnr:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 568);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.visaMedlemsInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bokningar);
            this.Controls.Add(this.visaBokning);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FakturorListbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.faktisktÅterlämningsdatum);
            this.Controls.Add(this.Bokningsnummer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.slutdatumpick);
            this.Controls.Add(this.startdatumpick);
            this.Controls.Add(this.medlemsNrLB);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.lämnatillbakaBok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lånaböcker);
            this.Controls.Add(this.TillgängligaBöcker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox TillgängligaBöcker;
        private System.Windows.Forms.Button lånaböcker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lämnatillbakaBok;
        private System.Windows.Forms.Button avsluta;
        private System.Windows.Forms.ListBox medlemsNrLB;
        private System.Windows.Forms.DateTimePicker startdatumpick;
        private System.Windows.Forms.DateTimePicker slutdatumpick;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Bokningsnummer;
        private System.Windows.Forms.DateTimePicker faktisktÅterlämningsdatum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox FakturorListbox;
        private System.Windows.Forms.Button visaBokning;
        private System.Windows.Forms.ListBox bokningar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button visaMedlemsInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

