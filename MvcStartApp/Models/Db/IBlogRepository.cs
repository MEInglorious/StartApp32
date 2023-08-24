using System.Threading.Tasks;

namespace StartApp.Models.Db
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUsers();
    }
}
