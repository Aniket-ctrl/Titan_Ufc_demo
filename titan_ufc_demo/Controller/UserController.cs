using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using titan_ufc_demo.Models;
using titan_ufc_demo.Service;

namespace titan_ufc_demo.Controller
{

    [Produces("application/json")]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private  IUserService _userService { get; set; }
        public UserController(IUserService userService) {

            _userService = userService;
        
        }
        [HttpPost]

        
            

    public async Task<IActionResult> CreateUser([FromBody] Users users)
        {
            var data = await _userService.CreateUser(users);
            return Ok(data);
        }

        [HttpGet]
        [Route("{userid:int}/UserData")]
        public IActionResult GetUser(int userid)
        {
            var data = _userService.GetUser(userid);
            return Ok(data);
        }
        [HttpPut]

        public async Task<IActionResult > UpdateUser([FromBody] Users users)
        {
            var data = await _userService.UpdateUser(users);
            return Ok(data);

        }
        [HttpDelete]

        public async Task<IActionResult> DeleteUser([FromBody] Users users)
        {
            var data = await _userService.RemoveUser(users);
            return Ok(data);
        }

        



    }
}
