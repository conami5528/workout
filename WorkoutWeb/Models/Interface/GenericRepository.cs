using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutWeb.Models.Interface;


namespace WorkoutWeb.Models.Repository
{
    public class GenericRepository : IMainRepository<BodyBasicIndex >
    {
        private WorkoutEntities1 db = new WorkoutEntities1();

        public void Create(BodyBasicIndex instance)
        {
            db.BodyBasicIndex.Add(instance);
            db.SaveChanges();
        }

        public void Update(BodyBasicIndex instance)
        {
            var result = db.BodyBasicIndex.Where(w => w.ID == instance.ID && w.Date == instance.Date).FirstOrDefault();


            result.BMI = instance.BMI;
            result.BodyFat = instance.BodyFat;
            result.Height = instance.Height;
            result.SkeletalMuscleRate = instance.SkeletalMuscleRate;
            result.VisceralFat = instance.VisceralFat;
            result.Weight = instance.Weight;
          
            db.SaveChanges();
        }

        public void Delete(BodyBasicIndex instance)
        {
            var result = db.BodyBasicIndex.Where(w => w.ID == instance.ID && w.Date == instance.Date).FirstOrDefault();
            db.BodyBasicIndex.Remove(result);

            db.SaveChanges();
        }

        public BodyBasicIndex GetT(string _ID) 
        {
            var result = db.BodyBasicIndex
                .Where(S => S.ID == _ID )              
                .OrderByDescending(s => s.Date)
                .First()
                ;

            return result;

        }
        public BodyBasicIndex GetT(string _ID, DateTime _DateTime)
        {
            var result = db.BodyBasicIndex
                .Where(S => S.ID == _ID && S.Date == _DateTime)
                .OrderByDescending(s => s.Date)
                .First()
                ;

            return result;

        }

        public List<BodyBasicIndex > GetAll()
        {
            var result = db.BodyBasicIndex;

            return  result.Take(10).ToList();
            
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