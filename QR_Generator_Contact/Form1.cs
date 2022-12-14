using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
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
            if (textBox_Nombre.Text== string.Empty)
            {
                MessageBox.Show("El Nombre no puede esta vacio");
                return;
            }
            if (textBox_posicion.Text== string.Empty)
            {
                MessageBox.Show("La Posicion no debe de estar vacia");
                return;
            }
            if (textBox_Direccion.Text== string.Empty)
            {
                MessageBox.Show("La Direccion no debe de estar vacia");
                return;
            }
            if (textBox_Correo.Text== string.Empty)
            {
                MessageBox.Show("El Correo no debe de estar vacio");
                return;
            }
            if (textBox_Telefono.Text== string.Empty)
            {
                MessageBox.Show("El Telefono no debe de estar vacio");
                return;
            }
            Datos_Usuario Carga_Usuario = new Datos_Usuario
            {
                Nombre = textBox_Nombre.Text,
                Posicion = textBox_posicion.Text,
                Direccion = textBox_Direccion.Text,
                Correo = textBox_Correo.Text,
                Celular = textBox_Celular.Text,
                Telefono = textBox_Telefono.Text,
                Pagina = textBox_Pagina.Text,
                Empresa = textBox_Empresa.Text,
            };
            var gen = new ContactData(ContactData.ContactOutputType.VCard21, Carga_Usuario.Nombre, string.Empty, workPhone: Carga_Usuario.Telefono, mobilePhone: Carga_Usuario.Celular, email: Carga_Usuario.Correo, street: Carga_Usuario.Direccion, orgTitle: Carga_Usuario.Posicion, website:Carga_Usuario.Pagina, org:Carga_Usuario.Empresa);
            var payload = gen.ToString();
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeAsBitmap = qrCode.GetGraphic(20, "#" + textBox_QR_Color.Text, "#FFFFFF", true);

            var image = new Bitmap(qrCodeAsBitmap, new Size(new Point(250, 250)));
            pictureBox_QR.BackgroundImage = image;
            button_Guardar_QR.Enabled = true;
        }
        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SpellcasterNG/Vcard_QR_Generator_Contact");
        }

        private void button_Guardar_QR_Click(object sender, EventArgs e)
        {
            Image image= (Image)pictureBox_QR.BackgroundImage.Clone();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Image PNG (*.png)|*.png";
            saveFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                image.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
            image.Dispose();
        }
    }
}
