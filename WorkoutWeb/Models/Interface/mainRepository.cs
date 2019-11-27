using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Web;
using System.Threading.Tasks;


namespace WorkoutWeb.Models.Interface
{
    public interface MainRepository<Tentity>
    {
        void Create(Tentity QQ);
        void Update(Tentity QQ);
        void Delete(Tentity QQ) ;
        Tentity GetT(int UserId);
        IQueryable<Tentity> GetAll();
        void SaveChanges();

        
    }
}