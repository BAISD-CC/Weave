using System.ComponentModel.DataAnnotations;

namespace Weave.Models 
{
    public class DeviceCheckout
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid DeviceId { get; set; }
        public Device Device { get; set; } = null!;

        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public DateTime CheckedOutAt { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnedAt { get; set; }
        
        public string? Notes { get; set; }
    }
}

