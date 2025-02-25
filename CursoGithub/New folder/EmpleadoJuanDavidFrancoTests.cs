using CursoGithub.Clases;
using Xunit;

namespace CursoGithub.Tests
{
    public class EmpleadoJuanDavidFrancoTests
    {
        [Fact]
        public void Constructor_ShouldInitializeProperties()
        {
            // Arrange
            string nombre = "Juan";
            string apellido = "Franco";
            int edad = 30;
            double salario = 1000.0;

            // Act
            var empleado = new EmpleadoJuanDavidFranco(nombre, apellido, edad, salario);

            // Assert
            Assert.Equal(nombre, empleado.Nombre);
            Assert.Equal(apellido, empleado.Apellido);
            Assert.Equal(edad, empleado.Edad);
            Assert.Equal(salario, empleado.Salario);
        }

        [Fact]
        public void SalarioNeto_ShouldReturnCorrectNetSalary()
        {
            // Arrange
            double salario = 1000.0;
            var empleado = new EmpleadoJuanDavidFranco("Juan", "Franco", 30, salario);
            double expectedNetSalary = salario - (salario * 0.10);

            // Act
            double actualNetSalary = empleado.SalarioNeto();

            // Assert
            Assert.Equal(expectedNetSalary, actualNetSalary);
        }
    }
}
