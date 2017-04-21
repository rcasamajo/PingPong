using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Tests
{
    [TestClass()]
    public class LligaTests
    {
        [TestMethod()]
        public void LligaTest()
        {
        }

        [TestMethod()]
        public void getJugadorTest_ForaRang()
        {
            Lliga lliga = new Lliga();
            Jugador jugador = lliga.getJugador(0);
            Assert.AreEqual(jugador, null);
        }

        [TestMethod()]
        public void getJugadorTest_Negatiu()
        {
            Lliga lliga = new Lliga();
            Jugador jugador = lliga.getJugador(-1);
            Assert.AreEqual(jugador, null);
        }

        [TestMethod()]
        public void delJugadorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}