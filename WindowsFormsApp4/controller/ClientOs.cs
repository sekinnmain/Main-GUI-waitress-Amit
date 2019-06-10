using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;


namespace WindowsFormsApp4.controller
{
    class ClientOs
    {
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

        Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] data = new byte[5120];


        public void ConnectToServer()
        {

            try
            {
                server.Connect(ip);
            }
            catch (SocketException e)
            {
                Console.WriteLine("Unable to connect to server.");
                return;
            }

        }

            public XDocument GetDataFromSrv()
        {
            int receivedDataLength = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
            XDocument xmlSample;
            xmlSample = XDocument.Parse(stringData);
            CloseSocketSrv();
            return (xmlSample);
        }

        public void CloseSocketSrv()
        {
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }



        



           
    }
}
