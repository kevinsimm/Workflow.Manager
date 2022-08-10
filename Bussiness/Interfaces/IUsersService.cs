using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Entity;

namespace Workflow.Manager.Bussiness.Interfaces
{
    public interface IUsersService
    {
        Task<List<Users>> GetAll();
    }
}
