using System.ComponentModel.DataAnnotations;

namespace EventManager.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(200)]
        public string Location { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        public int RegisteredParticipants { get; set; } = 0;
    }
}
