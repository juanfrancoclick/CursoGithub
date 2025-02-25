using CursoGithub.Clases;
using Xunit;

namespace CursoGithub.Tests
{
    public class JuanBedoyaTests
    {
        [Fact]
        public void CalcularSalarioNeto_DeberiaCalcularCorrectamente()
        {
            // Arrange
            var empleado = new JuanBedoya("Juan", "Bedoya", 30, 1000);

            // Act
            var salarioNeto = empleado.CalcularSalarioNeto();

            // Assert
            Assert.Equal(900, salarioNeto);
        }

        [Fact]
        public void ObtenerNombreCompleto_DeberiaConcatenarNombreYApellido()
        {
            // Arrange
            var empleado = new JuanBedoya("Juan", "Bedoya", 30, 1000);

            // Act
            var nombreCompleto = empleado.ObtenerNombreCompleto();

            // Assert
            Assert.Equal("Juan Bedoya", nombreCompleto);
        }
    }
}
