using AgroSys.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Infrastructure.Contracts
{
    public interface ICattlemanService
    {
        IEnumerable<Cattleman> GetCattlemans();
        Cattleman GetCattlemanByID(int cattlemanId);
        void InsertCattleman(Cattleman cattleman);
        void DeleteCattleman(int cattlemanID);
        void UpdateCattleman(Cattleman cattleman);
    }
}
