using Weave.Interfaces;
using Weave.Models;

namespace Weave.Services
{
    public class DataBreachService : IDataBreachService
    {
        public Task<List<DataBreach>> GetAllBreachesAsync()
        {
            var breaches = new List<DataBreach>
            {
                new()
                {
                    Username = "coolguy99",
                    Email = "coolguy99@example.com",
                    PlainTextPassword = "hunter2",
                    PasswordHash = "5d41402abc4b2a76b9719d911017c592", // MD5 of "hello"
                    BreachSource = "FakeBook",
                    BreachDate = new DateTime(2023, 5, 12)
                },
                new()
                {
                    Username = "jdoe",
                    Email = "jdoe@myemail.com",
                    PlainTextPassword = "password123",
                    PasswordHash = "482c811da5d5b4bc6d497ffa98491e38", // MD5 of "password123"
                    BreachSource = "MegaMail",
                    BreachDate = new DateTime(2022, 11, 3)
                },
                new()
                {
                    Username = "admin",
                    Email = "admin@123.com",
                    PlainTextPassword = "admin",
                    PasswordHash = "21232f297a57a5a743894a0e4a801fc3", // MD5 of "admin"
                    BreachSource = "HackPortal",
                    BreachDate = new DateTime(2024, 1, 18)
                },
                new()
                {
                    Username = "unicornlover",
                    Email = "unicorn@rainbowmail.com",
                    PlainTextPassword = "letmein",
                    PasswordHash = "0d107d09f5bbe40cade3de5c71e9e9b7", // MD5 of "letmein"
                    BreachSource = "SparkleChat",
                    BreachDate = new DateTime(2021, 8, 9)
                },
                new()
                {
                    Username = "student2025",
                    Email = "student@school.com",
                    PlainTextPassword = "qwerty",
                    PasswordHash = "d8578edf8458ce06fbc5bb76a58c5ca4", // MD5 of "qwerty"
                    BreachSource = "SchoolPortal",
                    BreachDate = new DateTime(2022, 2, 27)
                }
            };

            return Task.FromResult(breaches);
        }
    }
}
