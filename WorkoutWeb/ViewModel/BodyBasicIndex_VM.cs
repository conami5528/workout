using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkoutWeb.ViewModel
{
    public class BodyBasicIndex_VM
    {
        [Required]
        public string ID { get; set; }
        public string Weight { get; set; }
        public string BMI { get; set; }
        public string BodyFat { get; set; }
        public string SkeletalMuscleRate { get; set; }
        public string VisceralFat { get; set; }
        [Required] 
        public System.DateTime Date { get; set; }
    }
}