using Dapper;
using EFCore2VSDapper.Models;
using Microsoft.EntityFrameworkCore;
using NowMobRep.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class DapperRepository
    {
        public List<UsersGeneral> GetUsersWithDapper()
        {
            using (IDbConnection db = new SqlConnection(@"Server=192.168.112.20\SQLEXPRESS;Database=DBNAME;User Id=sa;Password=Password;Trusted_Connection=false;"))
            {
                return db.Query<UsersGeneral>
                ($"select top 5000 * from users_general").ToList();

            }
        }
    }
}
