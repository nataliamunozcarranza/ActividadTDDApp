using ActividadTDDApp;
namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-1, -1)]  
        [DataRow(-10, -1)]  
        [DataRow(0, 1)]     
        [DataRow(1, 1)]
        [DataRow(5, 120)]
        [DataRow(10, 3628800)]
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, resultado);
        }


        [TestMethod]
        [DataRow(null, false)]      
        [DataRow("", false)]          
        [DataRow("Ab#1234", false)]    
        [DataRow("abcdefgh", false)]    
        [DataRow("abcdefg#", true)]     
        [DataRow("Clave#Segura1", true)]
        public void EsContrasenyaValida_VariosCasos(string? contrasenya, bool esperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(esperado, resultado);
        }
    }
}
