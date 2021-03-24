using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Library_Mangement_system.PL
{
    public partial class ChatRoom : Form
    {

        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        public ChatRoom() 
        {
            InitializeComponent();
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            //Set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Get user IP
            txtLocalIp.Text = GetLocalIP();
            txtRemoteIP.Text = GetLocalIP();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // binding Socket
            IPAddress Local = IPAddress.Parse(txtLocalIp.Text);
            epLocal = new IPEndPoint(Local, Convert.ToInt32(txtLocalPort.Text));
            sck.Bind(epLocal);
            // Connecting to remote IP
            IPAddress Remote = IPAddress.Parse(txtLocalIp.Text);
            epRemote = new IPEndPoint(Remote, Convert.ToInt32(txtRemotePort.Text));
            sck.Connect(epRemote);
            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                 AsyncCallback(MessageCallBack), buffer);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Convert String Message to byte[]
            ASCIIEncoding aEnocding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEnocding.GetBytes(txtScreen.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage);
            //adding to the listbox
            txtScreen.Items.Add("Me:  " + txtMessage.Text);
            txtMessage.Text = "";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {

                byte[] receiveData = new byte[1500];
                receiveData = (byte[])aResult.AsyncState;
                //Converting byte[] to string
                ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
                String receiveMessage = aSCIIEncoding.GetString(receiveData);
                // Adding This Message into listbox
                txtScreen.Items.Add("Abd allah:  " + receiveMessage);
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private string GetLocalIP() //Get Local IP
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "172.0.0.1";
        }

    }
}
