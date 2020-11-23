using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class PostCounty
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        public string CountyName { get; set; }
        public int Population { get; set; }
        public int RecordId { get; set; }

    }
}
