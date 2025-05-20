using System.ComponentModel.DataAnnotations;

namespace Weave.Models {
    public class EventParticipation
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string EventName { get; set; } = null!;

        public DateTime Date { get; set; }

        public string? Role { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
