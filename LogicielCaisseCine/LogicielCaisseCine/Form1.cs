using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace LogicielCaisseCine
{
    // Fenêtre principale de la caisse du cinéma
    public partial class Form1 : Form
    {
        // Variables pour suivre l'état de la commande en cours
        private decimal prixBaseFilm = 9.00m;
        private string filmSelectionne = "";
        private decimal reductionAppliquee = 0.00m;
        private string nomReduction = "";
        private decimal totalAPayer = 0.00m;

        // Constructeur du formulaire
        public Form1()
        {
            InitializeComponent();
        }

        // Initialisation à l'ouverture de l'application
        private void Form1_Load(object sender, EventArgs e)
        {
            MettreAJourAffichage();
        }

        // Événement de modification de la zone d'aperçu (laissé vide)
        private void Apercu_TextChanged(object sender, EventArgs e)
        {

        }

        // Événement de modification de la zone de journal (laissé vide)
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Boutons de sélection des films
        private void Film1_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 1");
        }

        private void Film2_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 2");
        }

        private void Film3_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 3");
        }

        private void Film4_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 4");
        }

        private void Film5_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 5");
        }

        private void Film6_Click(object sender, EventArgs e)
        {
            AjouterFilm("Film 6");
        }

        // Enregistre le film choisi et réinitialise la réduction
        private void AjouterFilm(string nomFilm)
        {
            filmSelectionne = nomFilm;

            // Réinitialise la réduction si on change de film
            reductionAppliquee = 0.00m;
            nomReduction = "";

            CalculerTotal();
        }

        // Boutons de réductions et tarifs préférentiels
        private void PassRégion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmSelectionne))
            {
                MessageBox.Show("Veuillez d'abord sélectionner un film !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Place à 1€ soit une réduction de -8€ par rapport aux 9€ de base
            nomReduction = "Tarif Pass'Region (-8.00 euro)";
            reductionAppliquee = 8.00m;
            CalculerTotal();
        }

        private void RéducEtu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmSelectionne))
            {
                MessageBox.Show("Veuillez d'abord sélectionner un film !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Réduction Étudiant (-30%) -> 9 * 0.30 = 2.70 € de réduction
            nomReduction = "Tarif Etudiant (-30%)";
            reductionAppliquee = prixBaseFilm * 0.30m;
            CalculerTotal();
        }

        private void Senior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmSelectionne))
            {
                MessageBox.Show("Veuillez d'abord sélectionner un film !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Réduction Sénior (-20%) -> 9 * 0.20 = 1.80 € de réduction
            nomReduction = "Tarif Senior (-20%)";
            reductionAppliquee = prixBaseFilm * 0.20m;
            CalculerTotal();
        }

        // Boutons de validation du paiement
        private void Espece_Click(object sender, EventArgs e)
        {
            ValiderPaiement("Espèces");
        }

        private void CB_Click(object sender, EventArgs e)
        {
            ValiderPaiement("Carte Bancaire");
        }

        private void Chuèque_Click(object sender, EventArgs e)
        {
            ValiderPaiement("Chèque");
        }

        // Finalise la commande, affiche le ticket validé et réinitialise les variables
        private void ValiderPaiement(string moyenPaiement)
        {
            if (string.IsNullOrEmpty(filmSelectionne))
            {
                MessageBox.Show("Aucun film n'a été sélectionné pour le règlement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Affichage du reçu validé dans la zone Apercu
            Apercu.Clear();
            Apercu.AppendText("=====================================\n");
            Apercu.AppendText("           TICKET VALIDE             \n");
            Apercu.AppendText("=====================================\n\n");
            Apercu.AppendText($"Film : {filmSelectionne}\n");
            Apercu.AppendText($"Prix plein tarif : {prixBaseFilm:C2}\n");

            if (!string.IsNullOrEmpty(nomReduction))
            {
                Apercu.AppendText($"Réduction : {nomReduction}\n");
            }

            Apercu.AppendText($"-------------------------------------\n");
            Apercu.AppendText($"TOTAL PAYÉ : {totalAPayer:C2}\n");
            Apercu.AppendText($"Mode de règlement : {moyenPaiement}\n");
            Apercu.AppendText("=====================================\n");
            Apercu.AppendText("\n--- Commande terminée ---");

            MessageBox.Show($"Paiement de {totalAPayer:C2} effectué par {moyenPaiement}.", "Paiement réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Réinitialisation pour le client suivant
            filmSelectionne = "";
            reductionAppliquee = 0.00m;
            nomReduction = "";
            totalAPayer = 0.00m;
        }

        // Calcule le montant restant à payer
        private void CalculerTotal()
        {
            totalAPayer = prixBaseFilm - reductionAppliquee;
            if (totalAPayer < 0) totalAPayer = 0;

            MettreAJourAffichage();
        }

        // Rafraîchit l'affichage de l'aperçu de la commande en cours
        private void MettreAJourAffichage()
        {
            Apercu.Clear();
            Apercu.AppendText("=====================================\n");
            Apercu.AppendText("          APERÇU DE LA COMMANDE      \n");
            Apercu.AppendText("=====================================\n\n");

            if (string.IsNullOrEmpty(filmSelectionne))
            {
                Apercu.AppendText("Veuillez sélectionner un film...\n");
            }
            else
            {
                Apercu.AppendText($"Film sélectionné : {filmSelectionne}\n");
                Apercu.AppendText($"Prix de base : {prixBaseFilm:C2}\n\n");

                if (!string.IsNullOrEmpty(nomReduction))
                {
                    Apercu.AppendText($"Réduction : {nomReduction}\n");
                    Apercu.AppendText($"Montant déduit : -{reductionAppliquee:C2}\n\n");
                }

                Apercu.AppendText($"-------------------------------------\n");
                Apercu.AppendText($"TOTAL À PAYER : {totalAPayer:C2}\n");
                Apercu.AppendText($"-------------------------------------\n");
            }
        }

        // Génère et envoie le ticket par TCP à l'imprimante/Arduino
        private void ImprimerTicket_Click(object sender, EventArgs e)
        {
            // Vérifie qu'un film est bien sélectionné
            if (string.IsNullOrEmpty(filmSelectionne))
            {
                MessageBox.Show("Veuillez d'abord sélectionner un film avant d'imprimer !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère l'IP et le Port depuis les champs d'interface
            string ipArduino = IpAdresse.Text.Trim();
            if (string.IsNullOrEmpty(ipArduino))
            {
                MessageBox.Show("Veuillez renseigner l'adresse IP de l'imprimante.", "Adresse IP manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(Port.Text.Trim(), out int portArduino))
            {
                MessageBox.Show("Le port saisi est invalide.", "Port invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Récupère la date et l'heure courantes
            string dateHeurePaiement = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            // Récupère le numéro du film
            string numeroFilm = filmSelectionne.Replace("Film ", "").Trim();

            // Détermine le type de tarif
            string typeTarif = string.IsNullOrEmpty(nomReduction) ? "Plein Tarif" : nomReduction;

            // Construit la mise en page du ticket
            StringBuilder ticket = new StringBuilder();
            ticket.AppendLine("      CINEMA CAISSE CINE      ");
            ticket.AppendLine("================================");
            ticket.AppendLine($"            Salle {numeroFilm}            ");
            ticket.AppendLine($"            Film {numeroFilm}            ");
            ticket.AppendLine("--------------------------------");
            ticket.AppendLine($"   Tarif : {typeTarif}");
            ticket.AppendLine($"      Prix : {totalAPayer:C2}");
            ticket.AppendLine($" Paye le : {dateHeurePaiement} ");
            ticket.AppendLine("================================");
            ticket.AppendLine("\n\n\n");

            // Tente l'envoi de la trame via socket TCP
            try
            {
                using (TcpClient client = new TcpClient(ipArduino, portArduino))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] data = Encoding.UTF8.GetBytes(ticket.ToString());
                    stream.Write(data, 0, data.Length);

                    MessageBox.Show("Ticket envoyé à l'imprimante !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Impossible d'imprimer sur {ipArduino}:{portArduino} : {ex.Message}", "Erreur Impression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Effectue un test de connexion TCP vers l'adresse IP et le port
        private void Connexion_Click(object sender, EventArgs e)
        {
            string ipStr = IpAdresse.Text.Trim();
            string portStr = Port.Text.Trim();

            if (string.IsNullOrEmpty(ipStr) || string.IsNullOrEmpty(portStr))
            {
                MessageBox.Show("Veuillez saisir une adresse IP et un port valides.", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(portStr, out int port))
            {
                MessageBox.Show("Le port doit être un nombre entier valide (ex: 8080).", "Port invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Teste la connexion avec un délai d'attente de 3 secondes
            try
            {
                using (TcpClient client = new TcpClient())
                {
                    var result = client.BeginConnect(ipStr, port, null, null);
                    bool success = result.AsyncWaitHandle.WaitOne(3000);

                    if (success && client.Connected)
                    {
                        client.EndConnect(result);
                        MessageBox.Show($"Connexion réussie à l'imprimante sur {ipStr}:{port} !", "Succès Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Impossible de joindre {ipStr}:{port} (Délai d'attente dépassé).", "Échec Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du test de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Événement lors du changement de texte pour l'adresse IP (laissé vide)
        private void IpAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        // Événement lors du changement de texte pour le port (laissé vide)
        private void Port_TextChanged(object sender, EventArgs e)
        {

        }
    }
}