using C;
using ClubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubManagement.Controllers
{
    public class ClubManagementController : Controller
    {
        private IClubManagementService service;

        public ClubManagementController(ClubManagementService service)
        {
            this.service = service;
        }

        // GET: ClubManagement
        public ActionResult Student()
        {
            Person person = new Person
            {
                PersonId = 1,
                FirstName = "Bijay",
                LastName = "Yadav",
                Email = "b@g.com",
                Memberships = null
            };

            return View(person);
        }
    }
}