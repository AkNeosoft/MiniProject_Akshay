using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
   public interface IDishRepository
    {
        public List<Dish1> GetAllDishesV1();
        public List<Dish2> GetAllDishesV2();
    }
}
