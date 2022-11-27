namespace QR_Generator_Contact
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
            this.Label_Nombre = new System.Windows.Forms.Label();
            this.Label_Posicion = new System.Windows.Forms.Label();
            this.Label_Telefono = new System.Windows.Forms.Label();
            this.Label_Correo = new System.Windows.Forms.Label();
            this.Label_Direccion = new System.Windows.Forms.Label();
            this.Label_Celular = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_posicion = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Celular = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Correo = new System.Windows.Forms.TextBox();
            this.button_Generar_QR = new System.Windows.Forms.Button();
            this.button_Guardar_QR = new System.Windows.Forms.Button();
            this.pictureBox_QR = new System.Windows.Forms.PictureBox();
            this.textBox_Pagina = new System.Windows.Forms.TextBox();
            this.textBox_Empresa = new System.Windows.Forms.TextBox();
            this.Label_Pagina = new System.Windows.Forms.Label();
            this.Label_Empresa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Nombre
            // 
            this.Label_Nombre.AutoSize = true;
            this.Label_Nombre.Location = new System.Drawing.Point(21, 111);
            this.Label_Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Nombre.Name = "Label_Nombre";
            this.Label_Nombre.Size = new System.Drawing.Size(59, 16);
            this.Label_Nombre.TabIndex = 0;
            this.Label_Nombre.Text = "Nombre:";
            // 
            // Label_Posicion
            // 
            this.Label_Posicion.AutoSize = true;
            this.Label_Posicion.Location = new System.Drawing.Point(17, 165);
            this.Label_Posicion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Posicion.Name = "Label_Posicion";
            this.Label_Posicion.Size = new System.Drawing.Size(62, 16);
            this.Label_Posicion.TabIndex = 1;
            this.Label_Posicion.Text = "Posicion:";
            // 
            // Label_Telefono
            // 
            this.Label_Telefono.AutoSize = true;
            this.Label_Telefono.Location = new System.Drawing.Point(15, 220);
            this.Label_Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Telefono.Name = "Label_Telefono";
            this.Label_Telefono.Size = new System.Drawing.Size(64, 16);
            this.Label_Telefono.TabIndex = 2;
            this.Label_Telefono.Text = "Telefono:";
            // 
            // Label_Correo
            // 
            this.Label_Correo.AutoSize = true;
            this.Label_Correo.Location = new System.Drawing.Point(396, 165);
            this.Label_Correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Correo.Name = "Label_Correo";
            this.Label_Correo.Size = new System.Drawing.Size(51, 16);
            this.Label_Correo.TabIndex = 3;
            this.Label_Correo.Text = "Correo:";
            this.Label_Correo.Click += new System.EventHandler(this.Label_Correo_Click);
            // 
            // Label_Direccion
            // 
            this.Label_Direccion.AutoSize = true;
            this.Label_Direccion.Location = new System.Drawing.Point(377, 111);
            this.Label_Direccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Direccion.Name = "Label_Direccion";
            this.Label_Direccion.Size = new System.Drawing.Size(67, 16);
            this.Label_Direccion.TabIndex = 4;
            this.Label_Direccion.Text = "Direccion:";
            // 
            // Label_Celular
            // 
            this.Label_Celular.AutoSize = true;
            this.Label_Celular.Location = new System.Drawing.Point(395, 220);
            this.Label_Celular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Celular.Name = "Label_Celular";
            this.Label_Celular.Size = new System.Drawing.Size(52, 16);
            this.Label_Celular.TabIndex = 5;
            this.Label_Celular.Text = "Celular:";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(92, 107);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(276, 22);
            this.textBox_Nombre.TabIndex = 6;
            this.textBox_Nombre.Text = "Ingrese el nombre";
            // 
            // textBox_posicion
            // 
            this.textBox_posicion.Location = new System.Drawing.Point(92, 161);
            this.textBox_posicion.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_posicion.Name = "textBox_posicion";
            this.textBox_posicion.Size = new System.Drawing.Size(276, 22);
            this.textBox_posicion.TabIndex = 7;
            this.textBox_posicion.Text = "Ingrese la posicion";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(92, 217);
            this.textBox_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(276, 22);
            this.textBox_Telefono.TabIndex = 8;
            this.textBox_Telefono.Text = "Ingrese el telefono";
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Telefono_TextChanged);
            // 
            // textBox_Celular
            // 
            this.textBox_Celular.Location = new System.Drawing.Point(459, 217);
            this.textBox_Celular.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Celular.Name = "textBox_Celular";
            this.textBox_Celular.Size = new System.Drawing.Size(276, 22);
            this.textBox_Celular.TabIndex = 9;
            this.textBox_Celular.Text = "Ingrese el celular";
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(459, 107);
            this.textBox_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.Size = new System.Drawing.Size(276, 22);
            this.textBox_Direccion.TabIndex = 10;
            this.textBox_Direccion.Text = "Ingrese la direccion";
            // 
            // textBox_Correo
            // 
            this.textBox_Correo.Location = new System.Drawing.Point(459, 161);
            this.textBox_Correo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Correo.Name = "textBox_Correo";
            this.textBox_Correo.Size = new System.Drawing.Size(276, 22);
            this.textBox_Correo.TabIndex = 11;
            this.textBox_Correo.Text = "Ingrese el correo";
            // 
            // button_Generar_QR
            // 
            this.button_Generar_QR.Location = new System.Drawing.Point(92, 349);
            this.button_Generar_QR.Margin = new System.Windows.Forms.Padding(4);
            this.button_Generar_QR.Name = "button_Generar_QR";
            this.button_Generar_QR.Size = new System.Drawing.Size(277, 28);
            this.button_Generar_QR.TabIndex = 12;
            this.button_Generar_QR.Text = "Generar QR";
            this.button_Generar_QR.UseVisualStyleBackColor = true;
            this.button_Generar_QR.Click += new System.EventHandler(this.button_Generar_QR_Click);
            // 
            // button_Guardar_QR
            // 
            this.button_Guardar_QR.Location = new System.Drawing.Point(459, 349);
            this.button_Guardar_QR.Margin = new System.Windows.Forms.Padding(4);
            this.button_Guardar_QR.Name = "button_Guardar_QR";
            this.button_Guardar_QR.Size = new System.Drawing.Size(277, 28);
            this.button_Guardar_QR.TabIndex = 13;
            this.button_Guardar_QR.Text = "Gguadar";
            this.button_Guardar_QR.UseVisualStyleBackColor = true;
            // 
            // pictureBox_QR
            // 
            this.pictureBox_QR.Location = new System.Drawing.Point(893, 55);
            this.pictureBox_QR.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_QR.Name = "pictureBox_QR";
            this.pictureBox_QR.Size = new System.Drawing.Size(267, 246);
            this.pictureBox_QR.TabIndex = 14;
            this.pictureBox_QR.TabStop = false;
            // 
            // textBox_Pagina
            // 
            this.textBox_Pagina.Location = new System.Drawing.Point(460, 279);
            this.textBox_Pagina.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Pagina.Name = "textBox_Pagina";
            this.textBox_Pagina.Size = new System.Drawing.Size(276, 22);
            this.textBox_Pagina.TabIndex = 18;
            this.textBox_Pagina.Text = "Ingrese el celular";
            // 
            // textBox_Empresa
            // 
            this.textBox_Empresa.Location = new System.Drawing.Point(93, 279);
            this.textBox_Empresa.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Empresa.Name = "textBox_Empresa";
            this.textBox_Empresa.Size = new System.Drawing.Size(276, 22);
            this.textBox_Empresa.TabIndex = 17;
            // 
            // Label_Pagina
            // 
            this.Label_Pagina.AutoSize = true;
            this.Label_Pagina.Location = new System.Drawing.Point(396, 282);
            this.Label_Pagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Pagina.Name = "Label_Pagina";
            this.Label_Pagina.Size = new System.Drawing.Size(53, 16);
            this.Label_Pagina.TabIndex = 16;
            this.Label_Pagina.Text = "Pagina:";
            // 
            // Label_Empresa
            // 
            this.Label_Empresa.AutoSize = true;
            this.Label_Empresa.Location = new System.Drawing.Point(16, 282);
            this.Label_Empresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Empresa.Name = "Label_Empresa";
            this.Label_Empresa.Size = new System.Drawing.Size(65, 16);
            this.Label_Empresa.TabIndex = 15;
            this.Label_Empresa.Text = "Empresa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 441);
            this.Controls.Add(this.textBox_Pagina);
            this.Controls.Add(this.textBox_Empresa);
            this.Controls.Add(this.Label_Pagina);
            this.Controls.Add(this.Label_Empresa);
            this.Controls.Add(this.pictureBox_QR);
            this.Controls.Add(this.button_Guardar_QR);
            this.Controls.Add(this.button_Generar_QR);
            this.Controls.Add(this.textBox_Correo);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Celular);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_posicion);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.Label_Celular);
            this.Controls.Add(this.Label_Direccion);
            this.Controls.Add(this.Label_Correo);
            this.Controls.Add(this.Label_Telefono);
            this.Controls.Add(this.Label_Posicion);
            this.Controls.Add(this.Label_Nombre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SP QR Generator Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Nombre;
        private System.Windows.Forms.Label Label_Posicion;
        private System.Windows.Forms.Label Label_Telefono;
        private System.Windows.Forms.Label Label_Correo;
        private System.Windows.Forms.Label Label_Direccion;
        private System.Windows.Forms.Label Label_Celular;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_posicion;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Celular;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Correo;
        private System.Windows.Forms.Button button_Generar_QR;
        private System.Windows.Forms.Button button_Guardar_QR;
        private System.Windows.Forms.PictureBox pictureBox_QR;
        private System.Windows.Forms.TextBox textBox_Pagina;
        private System.Windows.Forms.TextBox textBox_Empresa;
        private System.Windows.Forms.Label Label_Pagina;
        private System.Windows.Forms.Label Label_Empresa;
    }
}

