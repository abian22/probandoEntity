using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace probandoEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private BookContext _context;

        public UserController(BookContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<User> Get() => _context.Users.ToList();
    }
}
