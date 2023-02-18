using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class UserController : ControllerBase
    {

        private readonly StoreContext _storeContext;
        public UserController(StoreContext storecontext)
        {
            _storeContext = storecontext;
        }

        //public List<User> GetUser("GetUser")
        //{



        //}

    }
}
