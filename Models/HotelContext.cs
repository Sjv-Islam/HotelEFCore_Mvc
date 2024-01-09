using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class HotelContext:DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public HotelContext(DbContextOptions opt) : base(opt)
        {

        }
    }
}

