﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Entity;

namespace Workflow.Manager.Repository.Interface
{
    public interface IUsersRepository
    {
        Task<List<Users>> GetAll();
    }
}
