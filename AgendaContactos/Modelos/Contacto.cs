using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos.Modelos
{
    public class Contacto
    {
        public int? Id { get; set; } = null;
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TelefonoPersonal { get; set; }
        public string TelefonoTrabajo { get; set; }
        public string TelefonoResidencial { get; set; }
        public string Categoria { get; set; }
        public string UrlFoto { get; set; } = null;
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Descripcion { get; set; }
        public string Apodo { get; set; }
        public bool isEmergencia { get; set; } = false;
        public bool isFavorito { get; set; } = false;
    }
    public class ContactoExportado : Contacto
    {
        public bool Seleccion { get; set; }
    }
}
