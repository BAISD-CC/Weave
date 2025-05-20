using System.ComponentModel.DataAnnotations;

namespace Weave.Models {
    public class Certificate
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public string Organization { get; set; } = null;

        [Required]
        public string Name { get; set; } = null!;
        
        public DateTime DateIssued { get; set; }

        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public Guid? MediaId { get; set; }
        public Media? Media { get; set; }
    }
}