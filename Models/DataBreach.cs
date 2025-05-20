namespace Weave.Models
{
    public class DataBreach
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PlainTextPassword { get; set; } = null!;
        public string BreachSource { get; set; } = null!;
        public DateTime BreachDate { get; set; }
    }
}