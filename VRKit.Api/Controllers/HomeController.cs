using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VRKit.Api.Helpers;
using VRKit.Common;
using VRKit.Models.Models;

namespace VRKit.Api.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : Controller
    {
        EntityHelper _context;

        public HomeController() {
            _context = new EntityHelper(new VRKitEntities());
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        [Route("read/lookups/{pKey}/{pType}")]
        public string Read_Lookup(string pKey, string pType) {
            string returnVal = String.Empty;

            returnVal = _context.Read_Lookup(pKey, pType);

            return returnVal;

        }

        [HttpGet]
        [Route("read/lookups/all")]
        public JsonResult Read_Lookup()
        {

            var returnVal = _context.Read_Lookup_Defaults();

            return Json(returnVal, JsonRequestBehavior.AllowGet);

        }


    }
}
