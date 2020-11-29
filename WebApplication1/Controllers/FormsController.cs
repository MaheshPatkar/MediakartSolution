using System;

using System.Collections.Generic;

using System.Data.Entity;

using System.Linq;

using System.Web;

using System.Web.Mvc;


using SampleSolution.Models;
using WebApplication1.Data;

namespace SampleSolution.Controllers

{
    public class FormsController : Controller

    {

        // GET: Form



        [HttpGet]

        public ActionResult Index()
        {

            return View();

        }





        [HttpPost]

        public ActionResult Index(ContactViewModel contact)

        {

            if (ModelState.IsValid)

            {

                CONTACT_INFO contactInfo = new CONTACT_INFO

                {

                    FIRST_NAME = contact.FirstName,

                    LAST_NAME = contact.LastName,

                    PHONE_NUMBER = contact.PhoneNumber,

                    MESSAGE = contact.YourMessage,

                    CONTACT_PURPOSE = contact.ContactPurpose,

                    EMAIL_ADDRESS = contact.YourEmail,

                };



                using (MEDIAKARTEntities entities = new MEDIAKARTEntities())

                {

                    entities.CONTACT_INFO.Add(contactInfo);

                    entities.SaveChanges();

                }
                return RedirectToAction("Index");
            }

            return View();

        }

    }

}