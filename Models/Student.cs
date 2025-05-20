using System.ComponentModel.DataAnnotations;

namespace Weave.Models {
    public class Student 
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string FullName { get; set; } = null!;

        // Pronouns and preferred names
        public string? PreferredName { get; set; }
        
        public string? Pronouns { get; set; }

        // Academic Information
        public int GraduationYear { get; set; }

        public int ProgramYear { get; set; }

        // Social and portfolio links
        public string? GitHubUsername { get; set; }

        public string? LinkedInUsername { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; } = true;

        // Related collections
        public ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
        public ICollection<DeviceCheckout> DeviceCheckouts { get; set; } = new List<DeviceCheckout>();
        public ICollection<ProjectStudent> ProjectLinks { get; set; } = new List<ProjectStudent>();
        public ICollection<EventParticipation> EventParticipations { get; set; } = new List<EventParticipation>();
        public ICollection<Media> MediaFiles { get; set; } = new List<Media>();
    }
}