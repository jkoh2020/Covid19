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
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
                      
        [Required]
        public int TodayTests { get; set; }
        [Required]
        public int TodayConfirmedCases { get; set; }
        [Required]
        public int TodayDeaths { get; set; }
        public int CountyId { get; set; }
        public string CountyName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedDate { get; set; }
    }
}
