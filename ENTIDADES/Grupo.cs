using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Grupo
    {
        public Grupo()
        {
        }

        public int GrupoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaHabilitado { get; set; }


    }
}
