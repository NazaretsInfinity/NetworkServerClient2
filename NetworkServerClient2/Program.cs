using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        public int queries {  get; set; }
        public DateTime LastQuery { get; set; }

        public Client(int queries, DateTime lastQuery)
        {
            this.queries = queries;
            LastQuery = lastQuery;
        }
    }


    internal class Program
    {

        private static Dictionary<string, Course> recipes = new Dictionary<string, Course>()
        {
            {"fuflo" , new Course("Mix all ingredients end pour down on your head", new string[]{"dirt", "pepper" }) },
            {"Fried egg", new Course("Crack the egg and pour into a preheated frying pan.\nAdd salt and cook for 5 minutes.",  new string[]{"egg","eggs","salt"}) }
        };

        
         private static Dictionary<IPEndPoint, Client> logs = new Dictionary<IPEndPoint, Client>(); // log of clients


        private static int PlaceAvailable = 5;
        private static readonly object loglock = new object();


        //=============== EXTRA MEMBERS END ============

        static void Main(string[] args)
        {
            int port = 12000;
            UdpClient udpServer = new UdpClient(port);
            Console.WriteLine("Sever active");
            ThreadPool.QueueUserWorkItem(new WaitCallback(UserKicker)); // check for 10 minutes if user activer or not 
            ThreadPool.QueueUserWorkItem((WaitCallback)QueriesUpdate);
            while (true)
            {
                try
                {
                    IPEndPoint clientPoint = new IPEndPoint(IPAddress.Any, port);
                    
                    byte[] receivedBytes = udpServer.Receive(ref clientPoint);
                    string received = Encoding.UTF8.GetString(receivedBytes);

                    if (!logs.ContainsKey(clientPoint)) // adding user for limit
                        if (PlaceAvailable != 0)
                        {
                            logs.Add(clientPoint, new Client(3, DateTime.Now)); //client has 3 query per hour available
                            ++PlaceAvailable;
                            Console.WriteLine($"user {clientPoint} was added to the log list");
                        }
                        else
                        {
                            byte[] deny = Encoding.UTF8.GetBytes("Server is full rn");
                            udpServer.Send(deny, deny.Length, clientPoint);
                            continue;
                        }



                    if (isRequestAllowed(clientPoint))
                    {
                        string RecipesToSend = GetRecipes(received);
                        byte[] responseBytes = Encoding.UTF8.GetBytes(RecipesToSend);
                        udpServer.Send(responseBytes, responseBytes.Length, clientPoint);
                        logs[clientPoint].LastQuery = DateTime.Now; // updating time of the last query
                    }
                    else
                    {
                        string response = "limit is out of range";
                        byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                        udpServer.Send(responseBytes, responseBytes.Length, clientPoint);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
        }
        static bool isRequestAllowed(object clientAddress)
        {
            IPEndPoint client = clientAddress as IPEndPoint;
            if (logs[client].queries == 0) return false;
            logs[client].queries--;
            return true;
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


        // for threads
        static void UserKicker(object a) // delete inactive clients
        {
            while(true)
            {
                DateTime now = DateTime.Now;
                lock (loglock) //change log list
                {
                    var keys = logs.Keys.ToList();
                    foreach (var user in keys)
                        if (now - logs[user].LastQuery >= TimeSpan.FromMinutes(10))
                        {
                            logs.Remove(user);
                            Console.WriteLine($"User {user} was deleted from the log list");
                            ++PlaceAvailable;
                        } 
                }
                Thread.Sleep(10000);
            }
        }


        static void QueriesUpdate(object a)
        {
            while (true)
            {
                lock (loglock) // change loglist
                {
                    {
                        var keys = logs.Keys.ToList();
                        foreach (var user in keys) logs[user].queries = 3;
                    }
                }
                Thread.Sleep(3600000);//Every hour update of query limit  
            }
        }
    }
}
