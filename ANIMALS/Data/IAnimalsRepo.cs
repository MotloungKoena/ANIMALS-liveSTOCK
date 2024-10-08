using ANIMALS.Models;

namespace ANIMALS.Data
{
    public interface IAnimalsRepo
    {
        IQueryable<Animal> GetAllAnimals();
        Animal GetAnimalById(int id);
        void AddAnimal(Animal animal);
    }
}
