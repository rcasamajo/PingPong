using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

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
    }
}
