using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToDoApi.Models;
using ToDoApi.Services;

namespace ToDoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<List<TaskModel>> GetAll()
        {
            return Ok(_taskService.GetAll());
        }

        [HttpPost]
        public ActionResult<TaskModel> Add([FromBody] string title)
        {
            var task = _taskService.Add(title);
            return CreatedAtAction(nameof(GetAll), task);
        }

        [HttpPut("{id}/done")]
        public IActionResult MarkAsDone(int id)
        {
            var result = _taskService.MarkAsDone(id);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _taskService.Delete(id);
            if (!result) return NotFound();
            return NoContent();
        }
    }
}

