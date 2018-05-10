using ProviderSupport.DAL;
using ProviderSupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProviderSupport.Controllers
{
    public class TransactionDetailController : Controller
    {
        private ProviderSupportContext db = new ProviderSupportContext();

        // GET: Display
        public ActionResult Index()
        {
            TransactionDetail M = new TransactionDetail();
            M.ServiceTypeList = db.ServiceTypes.ToList();
            M.SelectedAnswer = "";
            return View(M);
        }
    }
}