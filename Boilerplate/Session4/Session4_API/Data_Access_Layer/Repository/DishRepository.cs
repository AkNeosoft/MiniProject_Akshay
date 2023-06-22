using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repository
{
    public class DishRepository: IDishRepository
    {
        List<Dish1> dishes1;
        List<Dish2> dishes2;
        public DishRepository()
        {
            dishes1 = new List<Dish1>()
            {
                new Dish1{Id="1-v1",Name="Pav Bhaji",Descrption="Best in Town",Price=100},
                 new Dish1{Id="2-v1",Name="Vada Pav",Descrption="Best in Kalyan",Price=15},
                  new Dish1{Id="3-v1",Name="Misal Pav",Descrption="Best in Thane",Price=150}
            };
            dishes2 = new List<Dish2>()
            {
                new Dish2{Id="1-v2",Name=" Pav Bhaji Version-2",Descrption="Best in Town",Price=100},
                 new Dish2{Id="2-v2",Name="Vada Pav Version-2",Descrption="Best in Kalyan",Price=15},
                  new Dish2{Id="3-v2",Name="Misal Pav Version-2",Descrption="Best in Thane",Price=150}
            };
        }

        public List<Dish1> GetAllDishesV1()
        {
            return dishes1;
        }
        public List<Dish2> GetAllDishesV2()
        {
            return dishes2;
        }
    }
}
