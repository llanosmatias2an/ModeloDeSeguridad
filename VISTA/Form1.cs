using CONTROLADORA;
using ENTIDADES;
using MODELOS;

namespace VISTA
{
    public partial class Form1 : Form
    {
        private GrupoController grupoController;
        public Form1()
        {
            InitializeComponent();
             grupoController = new GrupoController();
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbHabilitado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarGrupo_Click(object sender, EventArgs e)
        {
            var descripcion = txtDescGrupo.Text;
            var nombre = txtNombreGrupo.Text;
            var habilitado = cbHabilitado.Checked;
            if (!string.IsNullOrWhiteSpace(nombre) ||
                !string.IsNullOrWhiteSpace(descripcion))
            {

                Grupo grupo = new Grupo(nombre, descripcion, habilitado);
                var result = grupoController.agregarGrupo(grupo);
                if (result)
                {
                    MessageBox.Show("Grupo agregado correctamente");
                } else
                {
                    MessageBox.Show("Error al agregar el grupo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos del grupo");            
            }
        }
    }
}