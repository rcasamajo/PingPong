using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace PingPong
{
    public class Jugador
    {
        [JsonIgnore] //Aquest camp no es serialitza
        public String Id { get; set; }
        [JsonProperty("Nom")] //Si l'atribut tingués nom diferent de la propietat JSON podem fer l'associació així
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
            return Id + " / " + Nom + " / " + Foto + " / " + Punts + " / " + Jugats;
        }
    }
}
