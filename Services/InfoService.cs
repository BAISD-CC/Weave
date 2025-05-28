using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Weave.Interfaces;

namespace Weave.Services
{
    public class InfoService : IInfoService
    {
        private readonly IWebHostEnvironment _env;

        public InfoService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<IResult> GetInfoAsync()
        {
            var path = Path.Combine(_env.ContentRootPath, "Pages", "Info.html");

            if (!File.Exists(path))
                return Results.NotFound("Info page not found.");

            var html = await File.ReadAllTextAsync(path);
            return Results.Content(html, "text/html");
        }
    }
}