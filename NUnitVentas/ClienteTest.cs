using CapaModelo;
using CapaDatos;

namespace NUnitVentas
{
    [TestFixture]
    public  class ClienteTest
    {

        public Cliente nuevoCliente = null;
    
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Cliente_RegistrarCliente_ReturnTrue()
        {
              nuevoCliente = new Cliente {
                IdCliente=0,
                TipoDocumento = "DNI",
                NumeroDocumento = "47151218",
                Nombre = "Jorge Muñoz",
                Direccion = "Prol. Huascar",
                Telefono = "981566223"
                //Activo = true
            };

            var resultado = CD_Cliente.Instancia.RegistrarCliente(nuevoCliente);

           
            // Afirmar: Comprobamos que el resultado sea verdadero, indicando que el registro fue exitoso
            Assert.IsTrue(resultado, "El cliente debería haberse registrado correctamente en la base de datos.");
        }

    }
}
