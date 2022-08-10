using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Entity;
using Workflow.Manager.Bussiness.Interfaces;
using Dapper;
using Workflow.Manager.Repository.Interface;

namespace Workflow.Manager.Bussiness.Services
{
    public class UsersService : IUsersService
    {
        protected readonly IUsersRepository usersRepository ;

        public UsersService(IUsersRepository _usersRepository)
        {
            usersRepository = _usersRepository;
        }
        public async Task<List<Users>> GetAll()
        {
            List<Users> lstUsers = new List<Users>();
            try
            {
                lstUsers = await usersRepository.GetAll();
            }
            catch (Exception)
            {

            }
            return lstUsers;
        }
    }
}
