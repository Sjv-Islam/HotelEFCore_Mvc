using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace WebApplication1.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime RentDate { get; set; } = DateTime.Now;

        [Required]

        public string GuestName { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }

        
        public int Age { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}

