using ANIMALS.Models;

namespace ANIMALS.Data
{
    public class AnimalsRepo : IAnimalsRepo
    {
        private readonly AnimalsDbContext _animalsDbContext;
        public AnimalsRepo(AnimalsDbContext animalsDbContext)
        {
            _animalsDbContext = animalsDbContext;
        }

        public void AddAnimal(Animal animal)
        {
            _animalsDbContext.Animals.Add(animal);
            _animalsDbContext.SaveChanges();
        }

        public IQueryable<Animal> GetAllAnimals()
        {
            return _animalsDbContext.Animals;
        }

        public Animal GetAnimalById(int id)
        {
            return _animalsDbContext.Animals.FirstOrDefault(j => j.Id == id);
        }
    }
}
