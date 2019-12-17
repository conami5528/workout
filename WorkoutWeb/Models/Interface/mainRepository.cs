using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Web;
using System.Threading.Tasks;


namespace WorkoutWeb.Models.Interface
{
    public interface IMainRepository<Tentity>
        where Tentity : class
    {
        void Create(Tentity QQ);
        void Update(Tentity QQ);
        void Delete(Tentity QQ) ;
        Tentity GetT(string UserId);
        List<Tentity> GetAll();
        void SaveChanges();

        
    }

    public interface BodyIndex_interface : IMainRepository<BodyBasicIndex>
    {

    }
}