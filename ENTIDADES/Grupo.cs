using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Grupo
    {
        public Grupo(string nombre, string descripcion, bool habilitado)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            EstaHabilitado = habilitado;
        }

        public string GrupoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaHabilitado { get; set; }


    }
}
