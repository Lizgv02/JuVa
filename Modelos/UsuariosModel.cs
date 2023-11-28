
namespace JuVa.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; } = 0;
        public string Nombre { get; set; }
        public string Usuario { get; set; }

        public int Tipo { get; set; } 

        public UsuariosModel (string Nombre, string Usuario, int Tipo)
        {
            this.Nombre = Nombre;
            this.Usuario = Usuario;
            this.Tipo = Tipo;
            UsuariosModelValidator validador = new UsuariosModelValidator(this);
        }
    }
}
