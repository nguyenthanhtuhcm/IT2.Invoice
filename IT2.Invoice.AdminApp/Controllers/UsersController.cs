using IT2.Invoice.ApiIntegration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace IT2.Invoice.AdminApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;
        
        public UsersController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
