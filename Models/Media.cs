using System.ComponentModel.DataAnnotations;

namespace Weave.Models 
{
    public class Media
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FileName { get; set; } = null!;
        [Required]
        public string Url { get; set; } = null!;
        [Required]
        public string MediaType { get; set; } = null!;

        public Guid? StudentId { get; set; }
        public Student? Student { get; set; }

        public Guid? ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
