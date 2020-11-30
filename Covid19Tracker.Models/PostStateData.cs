using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
   public class PostStateData
    {
        public int Id { get; set; }
       
             
        [Required]
        public int StateId { get; set; }
        public string StateName { get; set; }
        public int TodayTests { get; set; }
        [Required]
        public int TodayConfirmedCases { get; set; }
        [Required]
        public int TodayDeaths { get; set; }
        

        [Display(Name = "Created")]
        public DateTimeOffset CreatedDate { get; set; }
       
    }
}
