using NowMobRep.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class ADORepository
    {
        public List<UsersGeneral> GetUsersWithADO()
        {
            using (var conn = new SqlConnection(@"Server=192.168.112.20\SQLEXPRESS;Database=DbName;User Id=sa;Password=Password;Trusted_Connection=false;"))
            {
                var sql = "select top 5000 * from users_general";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        return (from DataRow dr in resultTable.Rows
                                           select new UsersGeneral()
                                           {
                                               Account = Convert.ToInt64(dr["Account"]),
                                               ClimapAccessCode = dr["display_sip_password"].ToString()
                                           }).ToList();
                    }
                }
            }
        }
    }
}
