using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using System;
using System.Threading.Tasks;

namespace MessageReceiver
{
    class Program
    {
        static string connectionString = "DefaultEndpointsProtocol=https;AccountName=manishapp0111;AccountKey=TMJY8O6xYhsoHPQ8YT9mYMvosW5EZ+5r1ODyysgLkRjiJH54F/9LuBiM0yhL9vc9jUlHLGqRyoCiPL98VjBKHg==;EndpointSuffix=core.windows.net";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //make a client for the appqueue that you have in your Azure queue storage
            QueueClient queueClient = new QueueClient(connectionString, "appqueue");

            QueueMessage[] queueMessages = queueClient.ReceiveMessages();
            foreach(QueueMessage msg in queueMessages)
            {
                //write the message body
                Console.WriteLine("Expires on: {0}, Inserted on: {1}, Message Body: {2}", msg.ExpiresOn,msg.InsertedOn,msg.Body);
            }
            Console.WriteLine("receiving operation Complete");
            Console.ReadKey();
        }
    }
}
