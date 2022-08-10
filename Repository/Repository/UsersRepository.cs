using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Manager.Bussiness.Entity;
using Workflow.Manager.Repository.Interface;

namespace Workflow.Manager.Repository.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public async Task<List<Users>> GetAll()
        {
            const string storeProcedure = "Task_GetOne";
            const int TaskId = 3; 
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var param = new DynamicParameters();
                param.Add("@ID", TaskId);
                var result = await con.QueryAsync<Users>(storeProcedure, param,
                    commandType: CommandType.StoredProcedure);
                con.Close();
                return result.ToList();

            }
        }
    }
}
