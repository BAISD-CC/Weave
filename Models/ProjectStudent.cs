namespace Weave.Models
{
    public class ProjectStudent
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;
    }
}
