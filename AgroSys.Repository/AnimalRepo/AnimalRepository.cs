using AgroSys.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Repository.AnimalRepo
{
    public class AnimalRepository : IAnimalRepository, IDisposable
    {
        private AgroSysDbContext context;

        public AnimalRepository(AgroSysDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return context.Animals.ToList();
        }

        public Animal GetAnimalByID(int id)
        {
            return context.Animals.Find(id);
        }

        public void InsertAnimal(Animal animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public void DeleteAnimal(int animalID)
        {
            Animal animal = context.Animals.Find(animalID);
            context.Animals.Remove(animal);
            context.SaveChanges();
        }

        public void UpdateAnimal(Animal animal)
        {
            context.Entry(animal).State = EntityState.Modified;
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
