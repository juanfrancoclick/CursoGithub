namespace CursoGithub.Clases
{
    public class JuanBedoya
    {
        //Crear clase empleado con variables nombre, apellido, edad, salario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public JuanBedoya(string nombre, string apellido, int edad, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Salario = salario;
        }

        // Crear un metodo que calcule el salario neto de un empleado, el salario neto se calcula restando el 10% del salario bruto
        public double CalcularSalarioNeto()
        {
            return Salario * 0.9;
        }


        /// <summary>
        /// Obtains the full name of the employee by concatenating the first name and last name.
        /// </summary>
        /// <returns>A string that represents the full name of the employee.</returns>
        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
