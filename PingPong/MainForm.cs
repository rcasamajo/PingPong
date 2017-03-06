using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using Firebase.Database;
using System.Threading.Tasks;

namespace PingPong
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

            /*
            //Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            MessageBox.Show(responseFromServer);
            */

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Jugador));
            Jugador p1 = (Jugador)ser.ReadObject(dataStream);

            MessageBox.Show(p1.ToString());

            // Clean up the streams and the response.  
            dataStream.Close();
            response.Close();
        }

        private void firebasedatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryFB();
        }

        private async Task QueryFB()
        {
            var firebase = new FirebaseClient("https://pingpong-f6fb0.firebaseio.com/");

            var jugadors = await firebase
             .Child("jugadors")
             .OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                MessageBox.Show(p1.Key + " -> " + p1.Object.ToString());
            }
        }
    }
}
