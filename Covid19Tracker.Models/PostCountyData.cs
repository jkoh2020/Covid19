using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class PostCountyData
    {
        public int CountyId { get; set; }

        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TodayTests { get; set; }
        [Required]
        public int TodayConfirmedCases { get; set; }
        [Required]
        public int TodayDeaths { get; set; }
        public int TotalTests { get; set; }
        public int TotalConfirmedCases { get; set; }
        public int TotalDeaths { get; set; }

        
    }
}
