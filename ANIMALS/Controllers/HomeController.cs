using ANIMALS.Data;
using ANIMALS.Models;
using Microsoft.AspNetCore.Mvc;

namespace ANIMALS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimalsRepo _animalsRepository;

        public HomeController(IAnimalsRepo animalsRepository)
        {
            _animalsRepository = animalsRepository;
        }


        [TempData]
        public string Message { get; set; }
        public IActionResult Index()
        {
            return View(_animalsRepository.GetAllAnimals().OrderByDescending(h => h.Price).Take(3));
        }

        public IActionResult ViewAll()
        {
            return View(_animalsRepository.GetAllAnimals().OrderByDescending(k => k.Price));
        }

        public IActionResult ViewAnimal(int id)
        {
            var animal = _animalsRepository.GetAnimalById(id);

            if (animal != null)
            {
                return View(animal);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult AddAnimal()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AddAnimal(Animal animal)
        {
            animal.DateOfBirth = DateTime.Now;
            if (ModelState.IsValid)
            {
                _animalsRepository.AddAnimal(animal);
                Message = $"Succesfully added {animal.Name} as an animal.";
                return RedirectToAction("Index");
            }
            else
            {
                return View(animal);
            }
        }
    }
}
