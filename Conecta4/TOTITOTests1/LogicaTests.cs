using Xunit;
using TOTITO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TOTITO.Tests
{
    public class LogicaTests
    {

        [Fact]
        public void VerificaGanadorTest()
        {
            Logica logica = new Logica();
              logica.Tablero[0,0] = "X";

                logica.Tablero[1,1] = "X";

                  logica.Tablero[2,2] = "X";
                  
                    logica.Tablero[3,3] = "X";
            Assert.Equal(true, logica.VerificaGanador(0));
        }

        [Fact]
        public void limpiarTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact]
        public void CambiarTurnoTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void ColocarFichaTest()
        {
            Assert.True(false, "This test needs an implementation");
        }

        [Fact()]
        public void GetStringTest()
        {
            Assert.True(false, "This test needs an implementation");
        }
    }
}
