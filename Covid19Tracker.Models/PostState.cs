using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class PostState
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at lease 2 characters.")]
        public string StateName { get; set; }
        public int Population { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedDate { get; set; }
    }
}
