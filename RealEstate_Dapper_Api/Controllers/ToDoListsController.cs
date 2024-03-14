using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ToDoListRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoListRepository _ToDoListRepository;
        public ToDoListsController(IToDoListRepository ToDoListRepository)
        {
            _ToDoListRepository = ToDoListRepository;
        }

        [HttpGet]
        [Route("ToDoLists")]
        public async Task<IActionResult> ToDoLists()
        {
            var values = await _ToDoListRepository.GetAllToDoListAsync();
            return Ok(values);
        }
    }
}
