using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Client_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string server = "127.0.0.1";
            int port = 12000;
            UdpClient udpClient = new UdpClient();
            IPEndPoint serverEP = new IPEndPoint(IPAddress.Parse(server), port);
            Console.WriteLine("Welcome to our badass cookin' center");

            while (true)
            {
                Console.WriteLine("Enter ingredients you have, then push ENTER");
                string message = Console.ReadLine();
                if (message == "no") break;
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, serverEP);

                string response = Encoding.UTF8.GetString(udpClient.Receive(ref serverEP));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(response);
                Console.ForegroundColor= ConsoleColor.Gray;
            }
            udpClient.Close();

        }
    }
}
