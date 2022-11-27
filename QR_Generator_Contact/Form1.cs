using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            QrEncoder qrEncoder = new QrEncoder();
            QrEncoder qrEncoder1 = new QrEncoder();
            QrCode qrCode = new QrCode();
            string holatu = "Nombre:"+ Carga_Usuario.Nombre + ", Posicion:" + Carga_Usuario.Posicion+", Direccion: "+ Carga_Usuario.Direccion+", Correo: "+ Carga_Usuario.Correo + ", Celular:" + Carga_Usuario.Celular+ ", Telefono:"+ Carga_Usuario.Telefono;
            qrEncoder.TryEncode(Convert.ToString(holatu), out qrCode);
            //qrEncoder1.
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var image = new Bitmap(imageTemporal, new Size(new Point(200,200)));
            pictureBox_QR.BackgroundImage = image;
        }




    }
}
