using Task_Solid.Models;

namespace Task_Solid.Interface
{
    public interface IServices
    {
        public User PrintDetails();
        public bool AddUser(UserViewModel userView);
        public List<User> GetAllUsers();
    }
}
