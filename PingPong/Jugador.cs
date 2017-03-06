using System;
using System.Runtime.Serialization;

namespace PingPong
{
    [DataContract]
    class Jugador
    {
        [DataMember]
        public String Nom { get; set; }
        [DataMember]
        public String Foto { get; set; }
        [DataMember]
        public int Punts { get; set; }
        [DataMember]
        public int Jugats { get; set; }

        public override String ToString()
        {
            return Nom + "/" + Foto + "/" + Punts + "/" + Jugats;
        }
    }
}
