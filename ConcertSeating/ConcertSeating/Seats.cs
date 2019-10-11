using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ConcertSeating
{
    public class Seat : Hub
    {
        public Task Select(int row, int col)
        {
           return Clients.All.SendAsync("Select", row, col);
        }
    }
}