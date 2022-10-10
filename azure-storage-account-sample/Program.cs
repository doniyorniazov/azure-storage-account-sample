using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Specialized;

namespace azure_storage_account_sample;
class Program
{
    static  void Main(string[] args)
    {
        string connectionString = "DefaultEndpointsProtocol=https;AccountName=doniyorstorage;AccountKey=NxHytN2IYTCRaFwxhYjaEZT71N0yY2xm59gHk5BMLPvu/e7oME35hq2xxr705mcsBZLQd5m11owF+ASt4F6pxw==;EndpointSuffix=core.windows.net";

        BlobServiceClient blobClient = new BlobServiceClient(connectionString);

        string sourceContainer = "firstcontainer";
        string destinationContainer = "thirdContainer";
        string sourceFileName = "DNO00301.jpg";

        string destionationFile = "Copied - DNO00301.jpg";
        var sourceClient = new BlockBlobClient(connectionString, sourceContainer, sourceFileName);
        var destinationClient = new BlockBlobClient(connectionString, destinationContainer, destionationFile);

         destinationClient.StartCopyFromUri(sourceClient.Uri);

        Console.WriteLine("Hello, World!");
    }
}

