using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Firebase.Database;
using System.Threading.Tasks;

namespace PingPong
{
    public partial class MainForm : Form
    {
        private Lliga LligaActual;

        public MainForm()
        {
            InitializeComponent();

            LligaActual = new Lliga();
            llegirFDAsync();

            var firebase = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");

            var observable = firebase
                .Child("jugadors")
                .AsObservable<Jugador>()
                .Subscribe(d => Console.WriteLine(d.Key + d.Object));
        }

        // Lectura dels jugadors usant la API de C# per a Firebase.
        private async Task llegirFDAsync()
        {
            String msg = "";

            var firebase = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.Id = p1.Key;
                LligaActual.NouJugador(p1.Object);

                msg = msg + p1.Object.ToString() + "\n";
            }

            MessageBox.Show(msg);
        }

        // Lectura dels jugadors usant la api REST de Firebase.
        private void llegirRESTMenuItem_Click(object sender, EventArgs e)
        {
            // Create a request for the URL
            WebRequest request = WebRequest.Create("https://pingpong-f6fb0.firebaseio.com/jugadors.json");

            // Get the response.  
            WebResponse response = request.GetResponse();

            // Display the status.
            //MessageBox.Show(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();

            //Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            MessageBox.Show(responseFromServer);
            
            reader.Close();
            response.Close();
        }

        private void MostrarJugadorsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(LligaActual.ToString());
        }

        // Exemple d'inserció d'un nou jugador.
        private async void insertFDMenuItem_Click(object sender, EventArgs e)
        {
            var client = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");
            var child = client.Child("jugadors");

            Jugador jugador = new Jugador("Anonymous", "no_foto");

            // Al fer l'insert ens retorna un FirebaseObject que conté la Key
            var p1 = await child.PostAsync(jugador);
            jugador.Id = p1.Key;
            LligaActual.NouJugador(jugador);

            MessageBox.Show("ok");
        }

        // Exemple de modificació d'un jugador: agafem el primer i li sumem un partit jugat.
        private async void modificarFDMenuItem_Click(object sender, EventArgs e)
        {
            if (LligaActual.getJugador(0) != null)
            {
                var client = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");
                var child = client.Child("jugadors/" + LligaActual.getJugador(0).Id);

                LligaActual.getJugador(0).Jugats++;

                await child.PutAsync(LligaActual.getJugador(0));

                MessageBox.Show("ok");
            }
        }

        // Exemple d'eliminació d'un jugador (agafem el primer).
        private async void eliminarFDMenuItem_Click(object sender, EventArgs e)
        {
            if (LligaActual.getJugador(0) != null)
            {
                var client = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");
                var child = client.Child("jugadors/" + LligaActual.getJugador(0).Id);

                await child.DeleteAsync();

                LligaActual.delJugador(0);

                MessageBox.Show("ok");
            }
        }
    }
}
