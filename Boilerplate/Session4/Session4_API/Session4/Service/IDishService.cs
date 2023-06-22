using Session4.Models;

namespace Session4.Service
{
    public interface IDishService
    {
        public List<Dish1> GetAllDishesV1();
        public List<Dish2> GetAllDishesV2();
    }
}
