using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace webbapp.Pages
{
    public class ImagesModel : PageModel
    {
         public List<Uri> allBlobs = new List<Uri>();
        public async Task<IActionResult> OnGet()
        {
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=lesson07gold;AccountKey=yxZ6ZzVBkMpylgvyq4+MqRSLUBsibHK/eH5FAV1F24pghALDnTHQh1DOvIovgKm+mnXZm/SC43kGhgkqOp6Cqw==;EndpointSuffix=core.windows.net";

            var storageAccount = CloudStorageAccount.Parse(connectionString);

            var _blobClient = storageAccount.CreateCloudBlobClient();

            var _blobContainer = _blobClient.GetContainerReference("imagesba0bde9d-ae96-4310-a026-bd3d81af150d");


            BlobContinuationToken blobContinuationToken = null;

            do
            {
                var response = await _blobContainer.ListBlobsSegmentedAsync(blobContinuationToken);
                foreach (IListBlobItem blob in response.Results)
                {
                    if (blob.GetType() == typeof(CloudBlockBlob))
                        allBlobs.Add(blob.Uri);
                }
                blobContinuationToken = response.ContinuationToken;
            } while (blobContinuationToken != null);

            return Page();
    }
}
}
