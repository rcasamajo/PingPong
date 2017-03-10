using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Lliga
    {
        private List<Jugador> Jugadors;

        public Lliga()
        {
            Jugadors = new List<Jugador>();
        }

        public void NouJugador(Jugador jugador)
        {
            Jugadors.Add(jugador);
        }

        public Jugador getJugador(int i)
        {
            return Jugadors[i];
        }
    }
}
