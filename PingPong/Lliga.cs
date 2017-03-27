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
            if (i < Jugadors.Count)
                return Jugadors[i];
            else
                return null;
        }

        public void delJugador(int i)
        {
            if (i < Jugadors.Count)
                Jugadors.RemoveAt(i);
        }

        public override String ToString()
        {
            String msg = "";

            foreach (Jugador jug in Jugadors)
                msg = msg + jug.ToString() + Environment.NewLine;

            return msg;
        }
    }
}
