using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAgenda.Models;

namespace WebAgenda.Controllers
{
    public class HomeController : Controller
    {
        webAgendaEntities db = new webAgendaEntities();

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public PartialViewResult EventList(string eventName = null, 
                                            string eventType = null, 
                                            DateTime? eventStartDate = null,
                                            DateTime? eventEndDate = null)
        {

            var query = db.sp_listEvents(eventName, eventType, eventStartDate, eventEndDate);
                        
                         
            return PartialView(query);
        }
    }
}