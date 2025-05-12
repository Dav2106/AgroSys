using AgroSys.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Infrastructure.Contracts
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals();
        Animal GetAnimalByID(int animalId);
        void InsertAnimal(Animal animal);
        void DeleteAnimal(int animalID);
        void UpdateAnimal(Animal animal);
    }
}
