using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Usuario
    {
        public string UsuarioID { get; set; }
        public int CantidadIntentos { get; }
        private string clave;
        public string Email { get; set; }
        public bool EstaAutentticado { get; }
        public bool EstaHabilitado { get; }
        public List<Grupo> Grupos { get; set; }

        public Usuario()
        {
            var Grupos = new List<Grupo>();

        }

        public void Agregar(Grupo grupo) { }
        public void CambiarClave(string claveActual, string claveNueva) { }
        public void IniciarSesion(string clave) { }
        public void Quitar(Grupo grupo) { }



    }
}
