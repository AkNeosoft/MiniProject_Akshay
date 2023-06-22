using Data_Access_Layer.Repository;
using Session4.Models;

namespace Session4.Service
{
    public class DishService: IDishService
    {
        readonly IDishRepository _dishRepository;
        public DishService(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }

        public List<Dish1> GetAllDishesV1()
        {
            return _dishRepository.GetAllDishesV1();
        }
        public List<Dish2> GetAllDishesV2()
        {
            return _dishRepository.GetAllDishesV2();
        }
    }
}
