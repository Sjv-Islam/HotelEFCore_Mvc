using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? RoomId { get; set; }
        [Required]
        public string RoomNumber { get; set; }

        public Category RoomType { get; set; }
        [Required]
        public decimal RoomRent { get; set; }
        public int Quantity { get; set; }


        public decimal TotalRoomRent => this.RoomRent * this.Quantity;

       
        public int? GuestId { get; set; }
        [DeleteBehavior(DeleteBehavior.Cascade)]
        public Guest? Guest { get; set; }

    }

    public enum Category
    {
        Standard,
        Premium,
        Deluxe
    }
}

