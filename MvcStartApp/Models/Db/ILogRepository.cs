using System.Threading.Tasks;

namespace StartApp.Models.Db
{
    public interface ILogRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetLogs();
    }
}
