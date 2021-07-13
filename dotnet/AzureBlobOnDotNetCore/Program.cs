using Azure.Storage.Blobs;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AzureBlobOnDotNetCore
{
    class Program
    {

        //storage account name : manishapp0111

        //access key:
        static string connectionString="DefaultEndpointsProtocol=https;AccountName=manishapp0111;AccountKey=YdU3LlUbY5niJMYnbgkBL3elyRa34HXxNennbTDy44GgOno+tPLPlrb1Pe+YdVCzLhuk/+rsk+JeqluGHDR6DQ==;EndpointSuffix=core.windows.net";
        static string fileToBeCopiedToCloudStorageBlob=@"D:\GITHUB\Notes\dotnet\1-dotnet-basics.md";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //created client for the blob service
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            //name of the blob container, in our case its 'data'
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient("data");

            //using this name they will create the file from the local fileToBeCopiedToCloudStorageBlob
            BlobClient blobClient = blobContainerClient.GetBlobClient("example.md");

            //open the file to upload
            using FileStream uploadFileStream = File.OpenRead(fileToBeCopiedToCloudStorageBlob);

            //await while it get uploaded
            await blobClient.UploadAsync(uploadFileStream, true);

            uploadFileStream.Close();

            Console.WriteLine("File Uploaded!");



            Console.WriteLine("Operation Complete.");








        }
    }
}
