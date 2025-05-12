using AgroSys.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Repository.CattlemanRepo
{
    public interface ICattlemanRepository : IDisposable
    {
        IEnumerable<Cattleman> GetCattlemans();
        Cattleman GetCattlemanByID(int cattlemanId);
        void InsertCattleman(Cattleman cattleman);
        void DeleteCattleman(int cattlemanID);
        void UpdateCattleman(Cattleman cattleman);
    }
}
