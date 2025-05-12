using AgroSys.Domain;
using AgroSys.Repository.CattlemanRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Repository.CattleManRepo
{
    public class CattlemanRepository : ICattlemanRepository
    {
        private AgroSysDbContext context;

        public CattlemanRepository(AgroSysDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Cattleman> GetCattlemans()
        {
            return context.CattleMans.ToList();
        }

        public Cattleman GetCattlemanByID(int id)
        {
            return context.CattleMans.Find(id);
        }

        public void InsertCattleman(Cattleman cattleman)
        {
            context.CattleMans.Add(cattleman);
            context.SaveChanges();
        }

        public void DeleteCattleman(int cattlemanID)
        {
            Cattleman cattleman = context.CattleMans.Find(cattlemanID);
            context.CattleMans.Remove(cattleman);
            context.SaveChanges();
        }

        public void UpdateCattleman(Cattleman cattleman)
        {
            context.Entry(cattleman).State = EntityState.Modified;
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
