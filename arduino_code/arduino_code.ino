#include <SPI.h>
#include <Ethernet.h>

// Sur Arduino Uno sans SoftwareSerial, l'imprimante utilise Serial (broches TX=1, RX=0).
// Le port série USB sert également de moniteur de débogage.
#define printerSerial Serial

// Définition de l'adresse MAC
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };

// Définition de l'adresse IP de l'Arduino
IPAddress ip(172, 18, 197, 98);

// Création du serveur TCP écoutant sur le port 8080
EthernetServer server(8080);

// Fonction d'impression de QR Code via le protocole ESC/POS
void printQRCode(const char* data) {
  uint16_t dataLen = strlen(data);
  uint16_t storeLen = dataLen + 3;

  uint8_t pL = storeLen % 256;
  uint8_t pH = storeLen / 256;

  // 1. Modèle (Modèle 2)
  uint8_t cmdModel[] = {0x1D, 0x28, 0x6B, 0x04, 0x00, 0x31, 0x41, 0x32, 0x00};
  printerSerial.write(cmdModel, sizeof(cmdModel));

  // 2. Taille du module (Taille 6)
  uint8_t cmdSize[] = {0x1D, 0x28, 0x6B, 0x03, 0x00, 0x31, 0x43, 0x06};
  printerSerial.write(cmdSize, sizeof(cmdSize));

  // 3. Correction d'erreur (Niveau M)
  uint8_t cmdEC[] = {0x1D, 0x28, 0x6B, 0x03, 0x00, 0x31, 0x45, 0x31};
  printerSerial.write(cmdEC, sizeof(cmdEC));

  // 4. Stockage des données
  uint8_t cmdHeader[] = {0x1D, 0x28, 0x6B, pL, pH, 0x31, 0x50, 0x30};
  printerSerial.write(cmdHeader, sizeof(cmdHeader));
  printerSerial.print(data);

  // 5. Impression du code QR
  uint8_t cmdPrint[] = {0x1D, 0x28, 0x6B, 0x03, 0x00, 0x31, 0x52, 0x30};
  printerSerial.write(cmdPrint, sizeof(cmdPrint));

  // Saut de ligne / avance papier
  printerSerial.write("\n\n\n");
}

void setup() {
  // Initialisation de la communication série à 9600 bauds pour l'imprimante
  printerSerial.begin(9600);

  // Initialisation du shield Ethernet
  Ethernet.begin(mac, ip);

  // Démarrage du serveur TCP
  server.begin();

  // Test d'impression initial (Exercice 1)
  // "Hello world" en gros
  printerSerial.write((uint8_t)0x1D); 
  printerSerial.write((uint8_t)0x21); 
  printerSerial.write((uint8_t)0x11);
  printerSerial.println("Hello world");

  // "Hello universe" en taille normale
  printerSerial.write((uint8_t)0x1D); 
  printerSerial.write((uint8_t)0x21); 
  printerSerial.write((uint8_t)0x00);
  printerSerial.println("Hello universe\n\n");
}

void loop() {
  // Attente d'un client connecté (application PC)
  EthernetClient client = server.available();

  if (client) {
    while (client.connected()) {
      if (client.available()) {
        // Read raw byte from TCP stream and forward directly to printer
        uint8_t b = client.read();
        printerSerial.write(b);
      }
    }
    // Fermeture de la connexion à la fin de la transmission
    client.stop();
  }
}
