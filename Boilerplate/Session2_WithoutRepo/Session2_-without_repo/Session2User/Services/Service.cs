using AutoMapper;
using Data_Access_Layer.dbContext;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Session2User.Interface;
using Session2User.Models;

namespace Session2User.Services
{
    public class Service: IService

    {
        readonly UserDbContext _userContext;
       
        private Mapper _userMapper;
        private Mapper _userViewModel;

       
        public Service( UserDbContext userDbContext)
        {
            _userContext=userDbContext;
           
            var _configUser = new MapperConfiguration(cfg => cfg.CreateMap<User, UserModel>().ReverseMap());
            _userMapper = new Mapper(_configUser);
            var _configUserViewModel = new MapperConfiguration(cfg => cfg.CreateMap<User, UserViewModel>().ReverseMap());
            _userViewModel = new Mapper(_configUserViewModel);
        }
        public List<UserModel> GetAllUsers()
        {
            List<User> user = _userContext.UserTbl.ToList();
            List<UserModel> userModel = _userMapper.Map<List<User>, List<UserModel>>(user);
            return userModel;
           
        }
        public bool AddUser(UserViewModel UVmodel)
        {
            User user = _userViewModel.Map<UserViewModel, User>(UVmodel);
            _userContext.UserTbl.Add(user);
            return _userContext.SaveChanges() == 1 ? true : false;
       
            
        }

        public UserModel GetUserById(int id)
        {
            User user = _userContext.UserTbl.Where(x => x.Id == id).FirstOrDefault();
            
            UserModel userM = _userMapper.Map<User, UserModel>(user);
            return userM;
        }
        public bool EditUser(UserModel Umodel)
        {
            User user = _userMapper.Map<UserModel, User>(Umodel);

            
            _userContext.Entry(user).State = EntityState.Modified;
            _userContext.SaveChanges();
            return true;
        }
        public bool DeleteUser(int id)
        {
            User user = _userContext.UserTbl.Where(x => x.Id == id).FirstOrDefault();
            Console.WriteLine(user.Name);
            if (user != null)
            {
                _userContext.UserTbl.Remove(user);
                _userContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
