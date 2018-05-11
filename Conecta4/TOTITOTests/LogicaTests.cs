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
            Logica sut = new Logica();
            sut.Tablero[0, 0] = "X";

            sut.Tablero[1, 1] = "X";

            sut.Tablero[2, 2] = "X";

            sut.Tablero[3, 3] = "X";;
            Assert.Equal(true, sut.VerificaGanador(0));
        }
    }
}