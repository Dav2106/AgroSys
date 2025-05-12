using AgroSys.Domain;
using AgroSys.Infrastructure.Contracts;
using AgroSys.Repository.AnimalRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroSys.Infrastructure.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void DeleteAnimal(int animalID)
        {
            _animalRepository.DeleteAnimal(animalID);
        }

        public Animal GetAnimalByID(int animalId)
        {
            return _animalRepository.GetAnimalByID(animalId);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _animalRepository.GetAnimals();
        }

        public void InsertAnimal(Animal animal)
        {
            _animalRepository.InsertAnimal(animal);
        }

        public void UpdateAnimal(Animal animal)
        {
            _animalRepository.UpdateAnimal(animal);
        }
    }
}
