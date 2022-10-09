using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

class Program
{
    public static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:8080");
        var client = new HelloService.HelloServiceClient(channel);
        var reply = await client.helloAsync(new HelloRequest() { FirstName = "Igor", LastName = "Bulinski"});
        Console.WriteLine("Greeting: " + reply.Greeting);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}