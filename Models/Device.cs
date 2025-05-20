using System.ComponentModel.DataAnnotations;

namespace Weave.Models {
    public class Device
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string SerialNumber { get; set; } = null!;

        public ICollection<DeviceCheckout> Checkouts { get; set; } = new List<DeviceCheckout>();
        
        public bool IsCheckedOut => Checkouts.Any(c => c.ReturnedAt == null);
    }
}