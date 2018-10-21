using System;
using System.Windows.Forms;

//For using socket class
using System.Net;
using System.Net.Sockets;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace Text_Chat
{
    public partial class Form1 : Form
    {
        private Socket sck;
        private EndPoint epLocal, epRemote;
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;

        public Form1()
        {
            InitializeComponent();
            //To use a which type protocol
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            locaip.Text = getLocalIp();
            locaip.Enabled = false;

            End.Visible = false;
            send.Enabled = false;

        }
        //To find a local ip
        public string getLocalIp()
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
            return "127.0.0.1";
        }
        private void messageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                //check the data in netowrk or not ?
                if ( size > 0 )
                {
                        byte[] receivedData = new byte[1464];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receviedMessage = eEncoding.GetString(receivedData);

                    messageworkspace.Items.Add("Friend : " + receviedMessage);

                    byte[] buffer = new byte[1500];
                    sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(localport.Text))
            {
                if (!String.IsNullOrEmpty(friendip.Text))
                {
                    if (!string.IsNullOrEmpty(friendport.Text))
                    {
                        try
                        {
                            epLocal = new IPEndPoint(IPAddress.Parse(locaip.Text), Convert.ToInt32(localport.Text));
                            sck.Bind(epLocal);

                            epRemote = new IPEndPoint(IPAddress.Parse(friendip.Text), Convert.ToInt32(friendport.Text));
                            sck.Connect(epRemote);

                            byte[] buffer = new byte[1500];
                            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(messageCallBack), buffer);

                            start.Text = "Connected";
                            start.Enabled = false;
                            locaip.Enabled = false;
                            friendip.Enabled = false;
                            localport.Enabled = false;
                            friendport.Enabled = false;
                            send.Enabled = true;
                            End.Enabled = true;
                            End.Visible = true;
                            textmessage.Focus();
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Your Port Address");
                        friendport.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Your Friend Ip Address");
                    friendip.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter port address");
                localport.Focus();
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textmessage.Text);

                sck.Send(msg);
                messageworkspace.Items.Add("Me : " + textmessage.Text);

                textmessage.Clear();
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void End_Click(object sender, EventArgs e)
        {
            try
            {
                start.Text = "Start";
                start.Enabled = true;
                locaip.Enabled = true;
                friendip.Enabled = true;
                localport.Enabled = true;
                friendport.Enabled = true;
                send.Enabled = false;
                Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void call_Click(object sender, EventArgs e)
        {

        }

 
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
