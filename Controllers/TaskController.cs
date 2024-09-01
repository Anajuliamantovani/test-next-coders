using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using Models.HttpResponse;
using Models.HttpRequest;
using Contexts;
using Models;
using System.Linq; //
using System.Threading.Tasks; //


namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly GerenciadorTarefasDbContext _context;
        public TaskController(GerenciadorTarefasDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateTask")]
        public async Task<IActionResult> CreateTask([FromBody] TasksRequest tasksRequest)
        {
            try
            {
                var newTask = new TaskModel
                {
                    Title = tasksRequest.Title,
                    Description = tasksRequest.Description,
                    Status = Enum.GetName(typeof(TasksStatus),TasksStatus.Pendente), //quando criada a tarefa, inicia como pendente
                    CreationDate = DateTime.Now, //a hora atual da criação da tarefa
                    ConclusionDate = null, 
                    IdUser = tasksRequest.UserId
                };
                _context.Tasks.Add(newTask);
                await _context.SaveChangesAsync();

                return Ok(newTask);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                var innerEx = ex.InnerException;

                while (innerEx != null)
                { 
                    message += ";" + Environment.NewLine + innerEx.Message;
                    innerEx = innerEx.InnerException;
                }
                
                return StatusCode(500, message);
            }
 
        }


        [HttpGet("ReadTask")]
        public async Task<IActionResult> ReadTask([FromQuery] string status)
        {
            try
            {
                   
                var tasks = await _context.Tasks
                    .Where(t => t.Status == status)
                    .ToListAsync();
                return Ok(tasks);    
            }

            catch(Exception)
            {
                return StatusCode(500);
            }
        }

        
        [HttpPut("UpdateTask")]
        public async Task<IActionResult> UpdateTask(long id, [FromBody] TasksResponse tasksResponse)    
        {
            try
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                {
                    return NotFound();
                }

                task.Title = tasksResponse.Title;
                task.Description = tasksResponse.Description;
                task.Status = tasksResponse.Status; //Att o status da tarefa
                task.ConclusionDate = tasksResponse.ConclusionDate;


                _context.Entry(task).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch(Exception)
            {
                return StatusCode(500);
            }
        }


        [HttpDelete("DeleteTask")]
        public async Task<IActionResult> DeleteTask(long id)
        {
            try
            {
                var task = await _context.Tasks.FindAsync(id);
                if (task == null)
                {
                    return NotFound();
                }

                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();

                return NoContent();
            }
             
            catch(Exception)
            {
                return StatusCode(500);
            }
        }
            
    }
}
