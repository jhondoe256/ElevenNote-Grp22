using Microsoft.AspNetCore.Mvc;

namespace ElevenNoteGrp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Userscontroller : ControllerBase
    {
        private readonly IUserService _userService;

        public Userscontroller(IUserService userService)
        {
            _userService = userService;
        }
    }
}