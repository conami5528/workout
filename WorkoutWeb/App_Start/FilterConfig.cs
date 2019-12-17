using System.Web;
using System.Web.Mvc;
using WorkoutWeb.Models.Repository;

namespace WorkoutWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        
        } 
    }
}
