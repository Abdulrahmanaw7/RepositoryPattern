using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Infrastructure.Repository.Base;
using RepositoryPattern.Models;

namespace RepositoryPattern.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorController(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var author = await _authorRepository.GetByIdAsync(id);
            return Ok(author);
        }
        [HttpGet("GetByIdAsync")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var author = await _authorRepository.GetByIdAsync(id);
            return Ok(author);


        }

    }
}
