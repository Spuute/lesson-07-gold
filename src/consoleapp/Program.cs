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
            BlobManager.UploadBlob();
        }
    }
}