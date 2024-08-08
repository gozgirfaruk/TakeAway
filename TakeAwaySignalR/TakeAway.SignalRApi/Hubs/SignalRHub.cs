using Microsoft.AspNetCore.SignalR;
using TakeAway.SignalRApi.DAL;

namespace TakeAway.SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly Context _context;

        public SignalRHub(Context context)
        {
            _context = context;
        }

        public async Task SendStatistic()
        {
            var value1 = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            await Clients.All.SendAsync("ReceiverStatusYolda", value1);

            var value2 = _context.Deliveries.Sum(x => x.TotalPrice);
            await Clients.All.SendAsync("ReceiverTotalPrice", value2);

            var value3 = _context.Deliveries.Count();
            await Clients.All.SendAsync("ReceiverTotalDelivery", value3);
        }
    }
}
