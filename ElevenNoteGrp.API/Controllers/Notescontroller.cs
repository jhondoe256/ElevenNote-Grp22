using Microsoft.AspNetCore.Mvc;

namespace ElevenNoteGrp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Notescontroller : ControllerBase
    {
        private readonly INoteService _noteService;

        public Notescontroller(INoteService noteService)
        {
            _noteService = noteService;
        }

        //....Controller stuff goes here....
    }
}