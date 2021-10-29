namespace Presentationslager
{
    partial class Inloggning
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
            this.button1 = new System.Windows.Forms.Button();
            this.användarnamn = new System.Windows.Forms.TextBox();
            this.lösen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lösenord = new System.Windows.Forms.Label();
            this.felkontroll = new System.Windows.Forms.Label();
            this.avsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logga in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // användarnamn
            // 
            this.användarnamn.Location = new System.Drawing.Point(19, 102);
            this.användarnamn.Name = "användarnamn";
            this.användarnamn.Size = new System.Drawing.Size(246, 26);
            this.användarnamn.TabIndex = 1;
            // 
            // lösen
            // 
            this.lösen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lösen.Location = new System.Drawing.Point(19, 171);
            this.lösen.Name = "lösen";
            this.lösen.Size = new System.Drawing.Size(246, 26);
            this.lösen.TabIndex = 2;
            this.lösen.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Borås bibliotek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Användarnamn:";
            // 
            // lösenord
            // 
            this.lösenord.AutoSize = true;
            this.lösenord.Location = new System.Drawing.Point(15, 148);
            this.lösenord.Name = "lösenord";
            this.lösenord.Size = new System.Drawing.Size(80, 20);
            this.lösenord.TabIndex = 5;
            this.lösenord.Text = "Lösenord:";
            // 
            // felkontroll
            // 
            this.felkontroll.AutoSize = true;
            this.felkontroll.Location = new System.Drawing.Point(15, 200);
            this.felkontroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.felkontroll.Name = "felkontroll";
            this.felkontroll.Size = new System.Drawing.Size(82, 20);
            this.felkontroll.TabIndex = 6;
            this.felkontroll.Text = "Felkontroll";
            // 
            // avsluta
            // 
            this.avsluta.Location = new System.Drawing.Point(53, 300);
            this.avsluta.Name = "avsluta";
            this.avsluta.Size = new System.Drawing.Size(158, 33);
            this.avsluta.TabIndex = 7;
            this.avsluta.Text = "Avsluta";
            this.avsluta.UseVisualStyleBackColor = true;
            this.avsluta.Click += new System.EventHandler(this.avsluta_Click);
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 345);
            this.Controls.Add(this.avsluta);
            this.Controls.Add(this.felkontroll);
            this.Controls.Add(this.lösenord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lösen);
            this.Controls.Add(this.användarnamn);
            this.Controls.Add(this.button1);
            this.Name = "Inloggning";
            this.Text = "Inloggning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox användarnamn;
        private System.Windows.Forms.TextBox lösen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lösenord;
        private System.Windows.Forms.Label felkontroll;
        private System.Windows.Forms.Button avsluta;
    }
}