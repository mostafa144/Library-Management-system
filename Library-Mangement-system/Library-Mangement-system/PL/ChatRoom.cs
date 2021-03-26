using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

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

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (textLocalPort.Text == "" && textRemotePort.Text == "")
            {
                MessageBox.Show("Type your port first");
            }
            else
            {
                MessageBox.Show("you are connected now");
            }

            // binding Socket
            IPAddress Local = IPAddress.Parse(textLocalIp.Text);
            epLocal = new IPEndPoint(Local, Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);
            // Connecting to remote IP
            IPAddress Remote = IPAddress.Parse(textLocalIp.Text);
            epRemote = new IPEndPoint(Remote, Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);
            //Listening the specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                 AsyncCallback(MessageCallBack), buffer);
            ofAbdo.Checked = false;
            onAbdo.Checked = true;
            ofmostafa.Checked = false;
            onMostafa.Checked = true;
        }

        private void ChatRoom_Load(object sender, EventArgs e)
        {
            //Set up socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //Get user IP
            textLocalIp.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            // Convert String Message to byte[]
            // send from Me to Abdallah
            ASCIIEncoding aEnocding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEnocding.GetBytes(textMessage.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage);
            //adding to the listbox
            if (textMessage.Text != "")
            {
                txtMessage.Items.Add("Abdallah :  " + textMessage.Text);
                txtScreen.Items.Add("Me :  " + textMessage.Text);
                textMessage.Text = "";
            }
            else
            {
                textMessage.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // send from Abdallah To Me
            ASCIIEncoding bEnocding = new ASCIIEncoding();
            byte[] sendingMessage2 = new byte[1500];
            sendingMessage2 = bEnocding.GetBytes(txtMessage2.Text);
            //Sending the Encoded message
            sck.Send(sendingMessage2);
            //adding to the listbox
            if (txtMessage2.Text != "")
            {
                txtScreen.Items.Add("Mostafa :  " + txtMessage2.Text);
                txtMessage.Items.Add("Me :  " + txtMessage2.Text);
                txtMessage2.Text = "";
            }
            else
            {
                txtMessage2.Focus();
            }

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
