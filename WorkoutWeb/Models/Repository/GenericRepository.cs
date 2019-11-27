using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutWeb.Models.Interface;

namespace WorkoutWeb.Models.Repository
{
    public class GenericRepository<Tentity> :  MainRepository<Tentity>
    {
        public void Create(Tentity instance)
        {
            throw new NotImplementedException();
        }

        public void Update(Tentity instance)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tentity instance)
        {
            throw new NotImplementedException();
        }

        public Tentity GetT(int primaryID) 
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tentity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}