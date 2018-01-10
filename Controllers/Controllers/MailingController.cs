using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            MailingList m1 = new MailingList();
            m1.FirstName = "Bob";
            m1.LastName = "Christianson";
            m1.Email = "bob.c@gmail.com";

            MailingList m2 = new MailingList();
            m2.FirstName = "Norman";
            m2.LastName = "Mailer";
            m2.Email = "nmailer@gmail.com";

            MailingList m3 = new MailingList();
            m3.FirstName = "Sarah";
            m3.LastName = "Silverman";
            m3.Email = "sarahsabadass@gmail.com";

            List<MailingList> mailings = new List<MailingList>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}