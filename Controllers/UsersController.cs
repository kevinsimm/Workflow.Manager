using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Entity;
using Workflow.Manager.Bussiness.Interfaces;

namespace Workflow.Manager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        protected readonly IUsersService usersService;
        public UsersController (IUsersService _usersService)
        {
            usersService = _usersService;
        }
        [HttpGet]
        [Route("getAllUsers")]
        public async Task<ResponeData> GetAllUser ()
        {
            var data = new ResponeData();
            try
            {
                var res = await usersService.GetAll();
                data.Users = res;
            }
            catch (Exception ex)
            {
                data.Code = 500;
                data.messages = ex.Message;
            }
            return data;
        }
    }

    // abc
    public class ResponeData
    {
        public int Code { get; set; }
        public string messages { get; set; }
        public List<Users> Users  { get; set; }
    }
}
