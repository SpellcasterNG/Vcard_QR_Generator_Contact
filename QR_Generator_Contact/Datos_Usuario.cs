using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QR_Generator_Contact
{
    public class Datos_Usuario
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Posicion { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}
