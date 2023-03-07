using Grpc.Core;
using ShipmentService;

namespace ShipmentService.Services
{
    public class ShipmentClass : Shipment.ShipmentBase
    {
        private readonly ILogger<ShipmentClass> _logger;
        public ShipmentClass(ILogger<ShipmentClass> logger)
        {
            _logger = logger;
        }

        public override Task<TransactionResponse> ShipItem(Ship s, ServerCallContext context)
        {
            AppendToFile(s);
            return Task.FromResult(new TransactionResponse { Status = true, Inventory = 1 });
        }

        public static async Task AppendToFile(Ship s)
        {
            using StreamWriter file = new("Shipments.txt", append: true);
            await file.WriteLineAsync(s.Address + ":" + s.Item);
            Console.WriteLine(s.Address + ":" + s.Item);
        }

    }
}