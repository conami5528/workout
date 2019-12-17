using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;
using WorkoutWeb.Models.Repository;
using WorkoutWeb.Models.BusinessLogic;
using WorkoutWeb.ViewModel;
using WorkoutWeb.Models;


namespace WorkoutWeb.Controllers
{
    [Authorize]
    public class BodyIndexController : Controller
    {
        // GET: BodyIndex
        private GenericRepository _repository = new GenericRepository();
        private BodyIndexLogic __repository = new BodyIndexLogic();
        
        [HttpGet]
        public ActionResult Index( )
        {

            return View(_repository.GetAll());
        }
        public PartialViewResult  BodyIndexTable()
        {
            

            return PartialView(_repository.GetAll());
        }
        public JsonResult AddBodyIndex(BodyBasicIndex_VM _model)
        {
          
            var result = __repository.Add(_model);

           return this.Json(result);
        }

        public JsonResult EditBodyIndex(BodyBasicIndex_VM _model)
        {
            
            var result = __repository.Edit(_model);

            return this.Json(result);
        }
        public JsonResult DelBodyIndex(BodyBasicIndex_VM _model)
        {

            var result = __repository.Del(_model);

            return this.Json(result);
        }
    }
}