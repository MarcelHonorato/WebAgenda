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

            var result = db.sp_listEvents(eventName, eventType, eventStartDate, eventEndDate);
                        
                         
            return PartialView(result);
        }

        [HttpPost]
        public ActionResult CreateEvent(string eventName, string eventDesc, DateTime? eventDate)
        {
            var result = db.sp_createEvent(eventName, eventDesc, eventDate).FirstOrDefault();

         
            return Json(new
            {
                result = (int)result            
            });


        }

        [HttpPost]
        public ActionResult AlterEvent(int eventId, string eventName, string eventDesc, DateTime? eventDate)
        {
            var result = db.sp_alterEvent(eventId, eventName, eventDesc, eventDate).FirstOrDefault();


            return Json(new
            {
                result = (int)result
            });


        }

        [HttpPost]
        public ActionResult DeleteEvent(int eventId)
        {
            var result = db.sp_deleteEvent(eventId).FirstOrDefault();


            return Json(new
            {
                result = (int)result
            });


        }
    }
}