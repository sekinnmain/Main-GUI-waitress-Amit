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
    public static class ClientOs
    {

        public static IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

        public static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static byte[] data = new byte[5120];


        public static void ConnectToServer()
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

        public static XDocument GetDataFromSrv()
        {
            int receivedDataLength = 0;
            receivedDataLength = server.Receive(data);
            string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
            XDocument xmlSample;
            xmlSample = XDocument.Parse(stringData);
            server.Disconnect(true);
            return (xmlSample);
        }

        public static void CloseSocketSrv()
        {
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        static bool SocketConnected(Socket s)
        {
            bool part1 = s.Poll(1000, SelectMode.SelectRead);
            bool part2 = (s.Available == 0);
            if (part1 && part2)
                return false;
            else
                return true;
        }






    }
}
