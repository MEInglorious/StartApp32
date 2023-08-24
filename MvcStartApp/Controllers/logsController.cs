using Microsoft.AspNetCore.Mvc;
using StartApp.Models.Db;
using System.Threading.Tasks;

namespace StartApp.Controllers
{
    public class LogsController : Controller
    {
        private readonly ILogRepository _logrepo;

        public LogsController(ILogRepository logrepo)
        {
            _logrepo = logrepo;
        }

        public async Task<IActionResult> Index()
        {
            var logs = await _logrepo.GetLogs();
            return View(logs);
        }
    }
}
