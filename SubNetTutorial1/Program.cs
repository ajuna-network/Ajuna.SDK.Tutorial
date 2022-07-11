using Ajuna.NetApi;
using System;
using System.Threading.Tasks;

namespace SubNetTutorial1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var uri = new Uri("ws://127.0.0.1:9944");
            SubstrateClient client = new SubstrateClient(uri);

            Console.WriteLine($"client.IsConnected: {client.IsConnected}");

            await client.ConnectAsync();

            Console.WriteLine($"client.IsConnected: {client.IsConnected}");

            Console.WriteLine($"SpecName: {client.RuntimeVersion.SpecName}");
            Console.WriteLine($"ImplName: {client.RuntimeVersion.ImplName}");
        }
    }
}
