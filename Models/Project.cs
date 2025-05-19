using System.ComponentModel.DataAnnotations;

namespace Weave.Models 
{
    public class Project
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsArchived { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        
        public ICollection<ProjectStudent> StudentLinks { get; set; } = new List<ProjectStudent>();
        public ICollection<Media> MediaFiles { get; set; } = new List<Media>();
    }
}
