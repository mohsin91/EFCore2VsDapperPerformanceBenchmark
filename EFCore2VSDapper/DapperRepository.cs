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
        public List<UsersGeneral> GetAllProductsByCategory(int categoryId)
        {
            using (IDbConnection db = new SqlConnection(@"Server=192.168.112.64\SQLEXPRESS;Database=NowMobileRepTest;User Id=sa;Password=Now12345;Trusted_Connection=false;"))
            {
                return db.Query<UsersGeneral>
                ($"select top 5000 * from users_general").ToList();

            }
        }
    }
}
