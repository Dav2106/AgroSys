using AgroSys.Domain;
using AgroSys.Infrastructure.Contracts;
using AgroSys.Repository.CattlemanRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Infrastructure.Services
{
    public class CattlemanService : ICattlemanService
    {
        private readonly ICattlemanRepository _cattlemanRepository;

        public CattlemanService(ICattlemanRepository cattlemanRepository)
        {
            _cattlemanRepository = cattlemanRepository;
        }

        public void DeleteCattleman(int cattlemanID)
        {
            _cattlemanRepository.DeleteCattleman(cattlemanID);
        }

        public Cattleman GetCattlemanByID(int cattlemanId)
        {
            return _cattlemanRepository.GetCattlemanByID(cattlemanId);
        }

        public IEnumerable<Cattleman> GetCattlemans()
        {
            return _cattlemanRepository.GetCattlemans();
        }

        public void InsertCattleman(Cattleman cattleman)
        {
            _cattlemanRepository.InsertCattleman(cattleman);
        }

        public void UpdateCattleman(Cattleman cattleman)
        {
            _cattlemanRepository.UpdateCattleman(cattleman);
        }
    }
}
