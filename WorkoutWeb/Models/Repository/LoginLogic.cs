using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutWeb.ViewModel;
using System.Web.Mvc;

namespace WorkoutWeb.Models.Repository
{
    public class LoginLogic
    {
        private WorkoutEntities1 db = new WorkoutEntities1();

        public string User { get; set; }
        public string Name { get; set; }

        public User GetT   (Login_VM _model )
        {
            var result = db.User.Where(x => x.ID == _model.ID && x.Password == _model.Password).FirstOrDefault();
            if (result != null )
            {
                User = result.ID;
                Name = result.Name;
            }
            return result;
        }

       
    }
    
    
}