namespace CursoGithub.Clases
{
    public class EmpleadoJuanDavidFranco
    {
        //Crear clase empleado con variables nombre, apellido, edad, salario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public EmpleadoJuanDavidFranco(string nombre, string apellido, int edad, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Salario = salario;
        }
        
    }
}
