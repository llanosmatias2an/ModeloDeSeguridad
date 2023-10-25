using ENTIDADES;
using MODELOS;

namespace CONTROLADORA
{
    public class GrupoController
    {
        private readonly Context _context;

        public GrupoController(Context context)
        {
            _context = context;
        }

        public bool agregarGrupo(Grupo grupo)
        {
            _context.Grupos.Add(grupo);
            var insert = _context.SaveChanges();
            if (insert == 1) return true;
            return false;
        }

        public bool eliminarGrupo(Grupo grupo)
        {
            _context.Grupos.Remove(grupo);
            var delete = _context.SaveChanges();
            if (delete == 1) return true;
            return false;
        }

        public bool modificarGrupo(Grupo grupo)
        {
            _context.Grupos.Update(grupo);
            var update = _context.SaveChanges();
            if (update == 1) return true;
            return false;
        }

        public List<Grupo> listarGrupos ()
        {
            return _context.Grupos.ToList();
        }


    }
}