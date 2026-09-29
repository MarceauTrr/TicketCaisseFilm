namespace LogicielCaisseCine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Apercu = new RichTextBox();
            Film1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            Connexion = new Button();
            PassRégion = new Button();
            Etudiant = new Button();
            button15 = new Button();
            Senior = new Button();
            ImprimerTicket = new Button();
            button18 = new Button();
            IpAdresse = new RichTextBox();
            Port = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Apercu
            // 
            Apercu.Location = new Point(12, 12);
            Apercu.Name = "Apercu";
            Apercu.Size = new Size(499, 360);
            Apercu.TabIndex = 0;
            Apercu.Text = "";
            Apercu.TextChanged += richTextBox1_TextChanged;
            // 
            // Film1
            // 
            Film1.Location = new Point(517, 12);
            Film1.Name = "Film1";
            Film1.Size = new Size(241, 177);
            Film1.TabIndex = 1;
            Film1.Text = "Film 1";
            Film1.UseVisualStyleBackColor = true;
            Film1.Click += Film1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(764, 12);
            button2.Name = "button2";
            button2.Size = new Size(232, 177);
            button2.TabIndex = 2;
            button2.Text = "Film 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Film2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(764, 195);
            button3.Name = "button3";
            button3.Size = new Size(232, 177);
            button3.TabIndex = 4;
            button3.Text = "Film 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Film4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(517, 195);
            button4.Name = "button4";
            button4.Size = new Size(241, 177);
            button4.TabIndex = 3;
            button4.Text = "Film 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Film3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(764, 378);
            button5.Name = "button5";
            button5.Size = new Size(232, 177);
            button5.TabIndex = 8;
            button5.Text = "Film 6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Film6_Click;
            // 
            // button6
            // 
            button6.Location = new Point(517, 378);
            button6.Name = "button6";
            button6.Size = new Size(241, 177);
            button6.TabIndex = 7;
            button6.Text = "Film 5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Film5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(764, 561);
            button7.Name = "button7";
            button7.Size = new Size(232, 74);
            button7.TabIndex = 9;
            button7.Text = "CB";
            button7.UseVisualStyleBackColor = true;
            button7.Click += CB_Click;
            // 
            // button8
            // 
            button8.Location = new Point(764, 643);
            button8.Name = "button8";
            button8.Size = new Size(232, 74);
            button8.TabIndex = 10;
            button8.Text = "Chèque";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Chuèque_Click;
            // 
            // button9
            // 
            button9.Location = new Point(517, 643);
            button9.Name = "button9";
            button9.Size = new Size(241, 74);
            button9.TabIndex = 12;
            button9.Text = "Autre";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(517, 561);
            button10.Name = "button10";
            button10.Size = new Size(241, 74);
            button10.TabIndex = 11;
            button10.Text = "Espèce";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Espece_Click;
            // 
            // Connexion
            // 
            Connexion.Location = new Point(12, 378);
            Connexion.Name = "Connexion";
            Connexion.Size = new Size(178, 78);
            Connexion.TabIndex = 14;
            Connexion.Text = "Connexion imprimante ...";
            Connexion.UseVisualStyleBackColor = true;
            Connexion.Click += Connexion_Click;
            // 
            // PassRégion
            // 
            PassRégion.Location = new Point(12, 462);
            PassRégion.Name = "PassRégion";
            PassRégion.Size = new Size(251, 87);
            PassRégion.TabIndex = 16;
            PassRégion.Text = "Tarif Pass'Région (place à 1€)";
            PassRégion.UseVisualStyleBackColor = true;
            PassRégion.Click += PassRégion_Click;
            // 
            // Etudiant
            // 
            Etudiant.Location = new Point(269, 462);
            Etudiant.Name = "Etudiant";
            Etudiant.Size = new Size(242, 87);
            Etudiant.TabIndex = 15;
            Etudiant.Text = "Etudiant (18 -> 26 ans) -30%";
            Etudiant.UseVisualStyleBackColor = true;
            Etudiant.Click += RéducEtu_Click;
            // 
            // button15
            // 
            button15.Location = new Point(12, 555);
            button15.Name = "button15";
            button15.Size = new Size(251, 87);
            button15.TabIndex = 18;
            button15.UseVisualStyleBackColor = true;
            // 
            // Senior
            // 
            Senior.Location = new Point(269, 555);
            Senior.Name = "Senior";
            Senior.Size = new Size(242, 87);
            Senior.TabIndex = 17;
            Senior.Text = "Sénior (+60ans) -20%";
            Senior.UseVisualStyleBackColor = true;
            Senior.Click += Senior_Click;
            // 
            // ImprimerTicket
            // 
            ImprimerTicket.Location = new Point(12, 654);
            ImprimerTicket.Name = "ImprimerTicket";
            ImprimerTicket.Size = new Size(251, 63);
            ImprimerTicket.TabIndex = 20;
            ImprimerTicket.Text = "Imprimer le ticket";
            ImprimerTicket.UseVisualStyleBackColor = true;
            ImprimerTicket.Click += ImprimerTicket_Click;
            // 
            // button18
            // 
            button18.Location = new Point(269, 654);
            button18.Name = "button18";
            button18.Size = new Size(242, 63);
            button18.TabIndex = 19;
            button18.UseVisualStyleBackColor = true;
            // 
            // IpAdresse
            // 
            IpAdresse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IpAdresse.Location = new Point(269, 378);
            IpAdresse.Name = "IpAdresse";
            IpAdresse.Size = new Size(242, 33);
            IpAdresse.TabIndex = 21;
            IpAdresse.Text = "";
            IpAdresse.TextChanged += IpAdresse_TextChanged;
            // 
            // Port
            // 
            Port.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Port.Location = new Point(269, 423);
            Port.Name = "Port";
            Port.Size = new Size(242, 33);
            Port.TabIndex = 22;
            Port.Text = "";
            Port.TextChanged += Port_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 389);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 23;
            label1.Text = "Adresse IP : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 434);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 24;
            label2.Text = "Port : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Port);
            Controls.Add(IpAdresse);
            Controls.Add(ImprimerTicket);
            Controls.Add(button18);
            Controls.Add(button15);
            Controls.Add(Senior);
            Controls.Add(PassRégion);
            Controls.Add(Etudiant);
            Controls.Add(Connexion);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(Film1);
            Controls.Add(Apercu);
            Name = "Form1";
            Text = "Caisse Cine";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox Apercu;
        private Button Film1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button Connexion;
        private Button PassRégion;
        private Button Etudiant;
        private Button button15;
        private Button Senior;
        private Button ImprimerTicket;
        private Button button18;
        private RichTextBox IpAdresse;
        private RichTextBox Port;
        private Label label1;
        private Label label2;
    }
}
