using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace BlobStorageV12
{
    public class BlobManager
    {
        public static void UploadBlob()
        {
            var filePath = @"C:\test-image.jpg";
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=lesson07gold;AccountKey=yxZ6ZzVBkMpylgvyq4+MqRSLUBsibHK/eH5FAV1F24pghALDnTHQh1DOvIovgKm+mnXZm/SC43kGhgkqOp6Cqw==;EndpointSuffix=core.windows.net";

            BlobClient blobClient = new BlobClient(connectionString: connectionString, blobContainerName: "imagesba0bde9d-ae96-4310-a026-bd3d81af150d", blobName: "Testing223231.jpg");

            blobClient.Upload(filePath);

            var blobUri = blobClient.Uri.AbsoluteUri;
            Console.WriteLine(blobUri);
        }
    }
}