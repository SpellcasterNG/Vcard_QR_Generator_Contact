using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace QR_Generator_Contact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label_Correo_Click(object sender, EventArgs e)
        {

        }

        private void button_Generar_QR_Click(object sender, EventArgs e)
        {
            //Carga_Usuario.
            Datos_Usuario Carga_Usuario = new Datos_Usuario
            {
                Nombre = textBox_Nombre.Text,
                Posicion = textBox_posicion.Text,
                Direccion = textBox_Direccion.Text,
                Correo = textBox_Correo.Text,
                Celular = textBox_Celular.Text,
                Telefono = textBox_Telefono.Text

            };

            var gen = new ContactData(ContactData.ContactOutputType.VCard4, Carga_Usuario.Nombre, string.Empty, phone: Carga_Usuario.Telefono, mobilePhone: Carga_Usuario.Celular, email: Carga_Usuario.Correo, street: Carga_Usuario.Direccion);
            var payload = gen.ToString();
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(20);

            var image = new Bitmap(qrCodeAsBitmap, new Size(new Point(200, 200)));
            pictureBox_QR.BackgroundImage = image;
        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
