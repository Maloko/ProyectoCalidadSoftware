using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitVentas
{

    [TestFixture]
    public  class ProductosTest
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Producto_EliminarProducto_ReturnTrue()
        {
            int idProducto = 6;

            var resultado = CD_Producto.Instancia.EliminarProducto(idProducto);

            // Afirmar: Comprobamos que el resultado sea verdadero, indicando que el registro fue exitoso
            Assert.True(resultado, "Producto eliminado correctamente");

            if (resultado)
            {
                TestContext.WriteLine("La prueba fue exitosa: El producto se correctamente.");
            }
            else
            {
                TestContext.WriteLine("La prueba falló: No se pudo eliminar el producto.");
            }

        }


    }
}
