using Covid19Tracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class GetCountiesData
    {
       
        public int DataId { get; set; }
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int TodayTests { get; set; }
        public int TodayConfirmedCases { get; set; }
        public int TodayDeaths { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedDate { get; set; }


    }
}
