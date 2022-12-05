using ClientsContactManagement.Business.Clients;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.AspNetCore.Mvc;

namespace ClientsContactManagement.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientBusiness _business;

        public ClientController(IClientRepository clientRepository)
        {
            _business = new ClientBusiness(clientRepository);
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetClients()
        {
            var clients = _business.GetAll();
            return Json(clients);
        }
    }
}
