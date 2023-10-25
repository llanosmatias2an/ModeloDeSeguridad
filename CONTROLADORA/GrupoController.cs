using ENTIDADES;
using Microsoft.EntityFrameworkCore;
using MODELOS;

namespace CONTROLADORA
{
    public class GrupoController
    {
        private readonly Context _context;

        public GrupoController()
        {
            _context = new Context();
        }

        public bool agregarGrupo(Grupo grupo)
        {
            _context.Grupos.Add(grupo);
            var insert = _context.SaveChanges();
            if (insert > 0) return true;
            return false;
        }

        public bool eliminarGrupo(Grupo grupo)
        {
            _context.Grupos.Remove(grupo);
            var delete = _context.SaveChanges();
            if (delete > 0) return true;
            return false;
        }

        public bool modificarGrupo(Grupo grupo)
        {
            _context.Grupos.Update(grupo);
            var update = _context.SaveChanges();
            if (update > 0) return true;
            return false;
        }

        public List<Grupo> listarGrupos ()
        {
            return _context.Grupos.ToList();
        }
        
        public Grupo listarGrupo(string nombre)
        {
            return _context.Grupos.First(x => x.Nombre == nombre);
        }
    }
}