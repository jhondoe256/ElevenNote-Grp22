using Microsoft.AspNetCore.Mvc;

namespace ElevenNoteGrp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Categorycontroller : ControllerBase
    {
        private readonly ICategoryService _catService;

        public Categorycontroller(ICategoryService catService)
        {
            _catService = catService;
        }
    }
}