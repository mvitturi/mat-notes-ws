
using Microsoft.AspNetCore.Mvc;

namespace mat_note_ws.Controllers
{
    [Route("[controller]")]
    public class NotesController : Controller
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
                if(id == 2)
                return NotFound($"Note missing. Id: {id}");

            return Ok(new NoteDto{Id = id, Content = "Ciao"});
        }

        [HttpPost]
        public IActionResult Create([FromBody] NoteDto note)
        {
            return Ok(note.Id);
        }
    }
}
