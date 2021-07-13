using System;
using System.Threading.Tasks;
using Azure.Storage.Queues;


namespace MessageSender
{
    class Program
    {

        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=manishapp0111;AccountKey=TMJY8O6xYhsoHPQ8YT9mYMvosW5EZ+5r1ODyysgLkRjiJH54F/9LuBiM0yhL9vc9jUlHLGqRyoCiPL98VjBKHg==;EndpointSuffix=core.windows.net";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //make a client for the appqueue that you have in your Azure queue storage
            QueueClient queueClient = new QueueClient(connectionString, "appqueue");
            queueClient.SendMessage("This is text message sent from the sender program.");
            Console.WriteLine("Sending operation Complete");
            Console.ReadKey();
        }
    }
}
