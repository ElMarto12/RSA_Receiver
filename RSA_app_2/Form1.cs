using RSA_app_2.utility;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Security.Cryptography;

namespace RSA_app_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void receive_btn_Click(object sender, EventArgs e)
        {

            // Priima žinutę ir parašą iš pirmosios aplikacijos
            string message = SocketReceiver.ReceiveMessage();

            // JSON konvertavimas į objektą
            var data = JsonSerializer.Deserialize<dynamic>(message);

            // Parsiunčiami duomenys iš JSON objekto
            string text = data.GetProperty("Text").GetString();
            byte[] signature = Convert.FromBase64String(data.GetProperty("Signature").GetString());

            string publicKeyJson = data.GetProperty("PublicKey").ToString();

            RSAParameters publicKey;
            using (JsonDocument document = JsonDocument.Parse(publicKeyJson))
            {
                JsonElement root = document.RootElement;

                byte[] modulus = Convert.FromBase64String(root.GetProperty("Modulus").GetString());
                byte[] exponent = Convert.FromBase64String(root.GetProperty("Exponent").GetString());

                publicKey = new RSAParameters
                {
                    Modulus = modulus,
                    Exponent = exponent
                };
            }

            // Tikrinamas parašas naudojant viešąjį raktą
            bool valid = Rsa.CheckSignature(text, signature, publicKey);

            if (valid == true)
            {
                MessageBox.Show("Parasas patvirtintas");
            }
            else
            {
                MessageBox.Show("Parasas Nepatvirtintas");
            }

            textBox1.Text = text;
            textBox2.Text = Convert.ToBase64String(signature);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}