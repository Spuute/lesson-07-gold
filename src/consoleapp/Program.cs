using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlobStorageV12
{
    class Program
    {
        public static async Task Main(string[] args)
        {
        //    CreateBlob().Wait();
        //    System.Console.WriteLine("Hello World!");
        // //    GetBlobs().Wait();
        //    Console.ReadKey();

            BlobManager.UploadBlob();
        }

    //     public static async Task CreateBlob(){
    //    string connectionString = "DefaultEndpointsProtocol=https;AccountName=lesson07gold;AccountKey=yxZ6ZzVBkMpylgvyq4+MqRSLUBsibHK/eH5FAV1F24pghALDnTHQh1DOvIovgKm+mnXZm/SC43kGhgkqOp6Cqw==;EndpointSuffix=core.windows.net";
    //     string containerName = "images" + Guid.NewGuid().ToString();
    //     string fileName = "test-image.jpg";
    //     string filePath = "C:\\test-image.jpg";

    //     BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
    //     BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName); // Skapar en ny container
    //     BlobClient blobClient = containerClient.GetBlobClient(fileName);
    //     using FileStream uploadFileStream = File.OpenRead(filePath);
    //     await blobClient.UploadAsync(uploadFileStream, true);
    //     uploadFileStream.Close();
    //     }

    }
}