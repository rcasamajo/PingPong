using System;
using System.Runtime.Serialization;

namespace PingPong
{
    class Jugador
    {
        public String Id { get; set; }
        public String Nom { get; set; }
        public String Foto { get; set; }
        public int Punts { get; set; }
        public int Jugats { get; set; }

        public Jugador(String nom, String foto)
        {
            Nom = nom;
            Foto = foto;
        }

        public override String ToString()
        {
            return Id + "/" + Nom + "/" + Foto + "/" + Punts + "/" + Jugats;
        }
    }
}
