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
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a request for the URL
            WebRequest request = WebRequest.Create("https://pingpong-f6fb0.firebaseio.com/jugadors/ID3.json");

            // Get the response.  
            WebResponse response = request.GetResponse();

            // Display the status.
            MessageBox.Show(((HttpWebResponse)response).StatusDescription);

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

        private async void firebasedatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var firebase = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");

            var jugadors = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.Id = p1.Key;
                LligaActual.NouJugador(p1.Object);

                MessageBox.Show(p1.Object.ToString());
            }
        }

        private async void firebaseDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var client = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");
            var child = client.Child("jugadors/" + LligaActual.getJugador(0).Id);

            Jugador jugador = new Jugador("Fulano", "fulano.jpg");

            await child.PutAsync(jugador);

            MessageBox.Show("ok");
        }
    }
}
