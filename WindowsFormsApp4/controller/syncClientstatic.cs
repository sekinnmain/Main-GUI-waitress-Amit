using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;

namespace Main.ClientOs
{

    public  class SynchronousSocketClient
    {
         IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        
         byte[] bytes = new byte[8192];

         XDocument xmlSample;

         public XDocument GetData()
        {
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 9999);

            // Create a TCP/IP  socket.  
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Connect the socket to the remote endpoint. Catch any errors.  
            try
            {
                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}",
                    sender.RemoteEndPoint.ToString());

                // Encode the data string into a byte array.  
                //byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                // Send the data through the socket.  
                //int bytesSent = sender.Send(msg);

                // Receive the response from the remote device.  
                int bytesRec = sender.Receive(bytes);
                string stringData = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                xmlSample = XDocument.Parse(stringData);

                Console.WriteLine("Echoed test = {0}",
                    Encoding.ASCII.GetString(bytes, 0, bytesRec));

                // Release the socket.  

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
                return xmlSample;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            return xmlSample;

        }

        //public static int Main(String[] args)
        //{
        //    StartClient();
        //    return 0;
        //}
    }
}