using BenchmarkDotNet.Attributes;
using EFCore2VSDapper.Models;
using NowMobRep.Models;
using System.Collections.Generic;

namespace EFCore2VSDapper
{
    public class EFCore2VsDapper
    {
        EFRepository _EFRepo;
        DapperRepository _DapperRepo;
        public EFCore2VsDapper()
        {
            _EFRepo = new EFRepository();
            _DapperRepo = new DapperRepository();
        }

        [Benchmark]
        public List<UsersGeneral> GetProductsWithEntityFramework() => _EFRepo.GetAllProductsByCategory(10);

        [Benchmark]
        public List<UsersGeneral> GetProductsWithDapper() => _DapperRepo.GetAllProductsByCategory(10);
    }
}
