using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_tecnica.Models
{
    public class UsuarioClass
    {
        public int idUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string apeUsuario { get; set; }
        public string correo { get; set; }
        public int idrol { get; set; }
        public int idMembresia { get; set; }
        public Usuario tipousuario { get; set; }
        public Role tiporol { get; set; }
        public Membresia tipoMembresia { get; set; }
        public string contrasena { get; set; }

    }
}