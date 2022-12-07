
using ClientsContactManagement.Business.Contacts;
using ClientsContactManagement.Repository.Contrasts;
using Microsoft.AspNetCore.Mvc;

namespace ClientsContactManagement.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactBusiness _business;

        public ContactController(IContactRepository contactRepository)
        {
            _business = new ContactBusiness(contactRepository);
        }
        public IActionResult Index() => View();

        [HttpGet]
        public JsonResult GetContacts()
        {
            var contacts = _business.GetContacts();
            return Json(contacts);
        }

        public IActionResult UnlinkContact(Guid code) 
        {
            _business.UnlinkContact(code);
            return RedirectToAction("Index");
        }
    }
}
