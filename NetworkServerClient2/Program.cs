using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkServerClient2
{
    class Course
    {
        public string Instruction { get; set; }
        public string[] Ingredients {  get; set; }
        
        public Course(string instruction, string[] ingredients)
        {
            this.Instruction = instruction;
            this.Ingredients = ingredients;
        }
    }

    class Client
    {
        public int AvailableRequests {get; set;}
        public IPEndPoint Address { get; set;}

        public Client(int availableRequests, IPEndPoint address)
        {
            AvailableRequests = availableRequests;
            Address = address;
        }
    }
    internal class Program
    {

        private static Dictionary<string, Course> recipes = new Dictionary<string, Course>()
        {
            {"fuflo" , new Course("Mix all ingredients end pour down on your head", new string[]{"dirt", "pepper" }) },
            {"Fried egg", new Course("Crack the egg and pour into a preheated frying pan.\nAdd salt and cook for 5 minutes.",  new string[]{"egg","eggs","salt"}) }
        };

        
         private static List<IPEndPoint> logs = new List<IPEndPoint>();
         private static int PlaceAvailable = 5;
        //=============== EXTRA MEMBERS END ============

        static void Main(string[] args)
        {
            int port = 1202;
            UdpClient udpServer = new UdpClient(port);
            Console.WriteLine("Sever active");


            while(true)
            {
                IPEndPoint clientPoint = new IPEndPoint(IPAddress.Any, port);
                if (!logs.Contains(clientPoint))
                    if (PlaceAvailable != 0)
                    {
                        logs.Add(clientPoint);
                        PlaceAvailable--;
                    }
                    else
                    {
                        byte[] deny = Encoding.UTF8.GetBytes("Server is full rn");
                        udpServer.Send(deny, deny.Length, clientPoint);
                        continue;
                    }
                
                
                    byte[] receivedBytes = udpServer.Receive(ref clientPoint);
                    string received = Encoding.UTF8.GetString(receivedBytes);

                    string RecipesToSend = GetRecipes(received);
                    byte[] responseBytes = Encoding.UTF8.GetBytes(RecipesToSend);
                    udpServer.Send(responseBytes, responseBytes.Length, clientPoint);
                
            }

            
        }
        private static string GetRecipes(string forrecipe)
        {
            List<string> result = new List<string>();
            string[] ingredients = forrecipe.Split(',');
            
            foreach(var recipe in recipes)
                if(ingredients.All(ing => recipe.Value.Ingredients.Contains(ing.Trim())))
                    result.Add(recipe.Key);

            // thought to convert the list in a string for console output right here
            if (result.Count == 0) return "Srs? what you thought you could do with this?\n";

            string response = "";
            foreach(string recipe in result)
                response += recipe + "\n" + recipes[recipe].Instruction + "\n";
            
            return response;
        }
    }
}
