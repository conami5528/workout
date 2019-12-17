using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkoutWeb.ViewModel;
using WorkoutWeb.Models.Repository;

namespace WorkoutWeb.Models.BusinessLogic
{
    public class BodyIndexLogic
    {

        public List<BodyBasicIndex>  Add( BodyBasicIndex_VM _VM)
        {
            GenericRepository _repository = new GenericRepository();

            BodyBasicIndex model = new BodyBasicIndex()
            {
                ID = _VM.ID,
                BMI = _VM.BMI,
                Date = _VM.Date,
                BodyFat = _VM.BodyFat,
                Height = _repository.GetT(_VM.ID).Height,
                SkeletalMuscleRate = _VM.SkeletalMuscleRate,
                VisceralFat = _VM.VisceralFat,
                Weight = _VM.Weight
            };

            _repository.Create(model);

            List<BodyBasicIndex> result = new List<BodyBasicIndex>();
            result.Add(_repository.GetT(model.ID, model.Date));
             

            return result;
        }

        public List<BodyBasicIndex> Edit(BodyBasicIndex_VM _VM)
        {
            GenericRepository _repository = new GenericRepository();

            BodyBasicIndex model = new BodyBasicIndex()
            {
                ID = _VM.ID,
                BMI = _VM.BMI,
                Date = _VM.Date,
                BodyFat = _VM.BodyFat,
                Height = _repository.GetT(_VM.ID).Height,
                SkeletalMuscleRate = _VM.SkeletalMuscleRate,
                VisceralFat = _VM.VisceralFat,
                Weight = _VM.Weight
            };

            _repository.Update(model);

            List<BodyBasicIndex> result = new List<BodyBasicIndex>();
            result.Add(_repository.GetT(model.ID, model.Date));


            return result;
        }
        public List<BodyBasicIndex> Del(BodyBasicIndex_VM _VM)
        {
            GenericRepository _repository = new GenericRepository();
            
            BodyBasicIndex model = new BodyBasicIndex()
            {
                ID = _VM.ID,
                BMI = _VM.BMI,
                Date = _VM.Date,
                BodyFat = _VM.BodyFat,
                Height = _repository.GetT(_VM.ID).Height,
                SkeletalMuscleRate = _VM.SkeletalMuscleRate,
                VisceralFat = _VM.VisceralFat,
                Weight = _VM.Weight
            };

            _repository.Delete(model);

            List<BodyBasicIndex> result = new List<BodyBasicIndex>();
            //result.Add(_repository.GetT(model.ID, model.Date));



            return result;
        }
    }
}