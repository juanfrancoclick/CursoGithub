namespace CursoGithub.Clases
{
    public class Juabet
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Juabet() { }
        public Juabet(string nombre, string apellido, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
        }


    }
}
