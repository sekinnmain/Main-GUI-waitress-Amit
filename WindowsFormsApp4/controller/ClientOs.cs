using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using System.Threading;

namespace WindowsFormsApp4.controller
{
    public static class ClientOs
    {

        public static IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);

        public static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static byte[] data = new byte[5120];


        public static ManualResetEvent allDone = new ManualResetEvent(false);
        //________________________________________________________
        private static bool FirstTimeVisited = true;
        private static XDocument xmlSample;
        private static string CurrentXmlData;
        private static XDocument xmlSampleEmpty;


        public static void ConnectCallback1(IAsyncResult ar)
        {
            allDone.Set();
            Socket s = (Socket)ar.AsyncState;
            s.EndConnect(ar);
        }

        public static void ConnectToServer()
        {

            try
            {

                allDone.Reset();
                server.BeginConnect(ip.Address, port: 9999, new AsyncCallback(ConnectCallback1), server);
                allDone.WaitOne();
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
            //receivedDataLength = server.Receive(data);
            //string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
            //XDocument xmlSample;
            //xmlSample = XDocument.Parse(stringData);
            //server.Disconnect(true);
            //FirstTimeVisited = false;
            //return (xmlSample);




            int receivedDataLength = 0;
            if(FirstTimeVisited)
            {
                receivedDataLength = server.Receive(data);
                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                CurrentXmlData = stringData;
                xmlSample = XDocument.Parse(stringData);
                server.Disconnect(true);
                FirstTimeVisited = false;
                return (xmlSample);
            }else
            {
                receivedDataLength = server.Receive(data);

                string stringData = Encoding.ASCII.GetString(data, 0, receivedDataLength);
                if(!stringData.Equals(CurrentXmlData))
                {
                    xmlSample = XDocument.Parse(stringData);
                    server.Disconnect(true);
                    FirstTimeVisited = false;
                    return (xmlSample);
                }
                return (xmlSampleEmpty);
            }
            
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
