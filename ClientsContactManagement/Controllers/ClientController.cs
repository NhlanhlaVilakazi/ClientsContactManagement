using ClientsContactManagement.Business.Clients;
using ClientsContactManagement.Repository.Contrasts;
using ClientsContactManagement.ViewModels.Client;
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
        public IActionResult Index() => View();

        [HttpGet]
        public JsonResult GetClients()
        {
            var clients = _business.GetAll();
            return Json(clients);
        }

        [HttpGet]
        public IActionResult NewClient() => View();

        public IActionResult NewClient(ClientViewModel client)
        {
            _business.AddClient(client);
            return RedirectToAction("Index");
        }

        public IActionResult LinkClient(string clientCode)
        {
            var client = _business.GetByCode(clientCode);
            return View(client);
        }
    }
}
