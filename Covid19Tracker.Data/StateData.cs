using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class StateData
    {
        [Key]
        public int DataId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Today { get; set; }
        public int TodayTests { get; set; }
        public int TodayConfirmedCases { get; set; }
        public int TodayDeaths { get; set; }

    //    // tests

    //    public int TotalTests { 
    //        get 
        
        
    //    }

    ////    public double Profit
    ////    {
    ////        get
    ////        {
    ////            return Rev - Cost;
    ////        }
    ////    }
    ////}


    public int StateId { get; set; }
        [ForeignKey(nameof(StateId))]
        public virtual State State { get; set; }
    }
}
