using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Models.HttpResponse;
using Models.HttpRequest;
using Contexts;
using Models;



namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly GerenciadorTarefasDbContext _contexto;
        public UserController(GerenciadorTarefasDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpPost("CreateUser")]
        public async Task <IActionResult> CreateUser([FromBody] UserRequest userRequest)
        {
            try
            {
                var user = new User
                {
                    name = userRequest.Name,
                    email = userRequest.Email,
                };

                 _contexto.Users.Add(user);
                 await _contexto.SaveChangesAsync();
                 return Ok(user);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(long id)
        {
            try 
            {
                var user = await _contexto.Users.FindAsync(id);
                if (user == null)
                {
                    return NotFound();
                }

                _contexto.Users.Remove(user);
                await _contexto.SaveChangesAsync();

                return NoContent();
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
        }
    }
}