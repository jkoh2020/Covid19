using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class County
    {
        [Key]
        public int CountyId {get;set;}
        public Guid UserId { get; set; }
        [Required]
        public string CountyName { get; set; }
        public int Population { get; set; }
    }
}
