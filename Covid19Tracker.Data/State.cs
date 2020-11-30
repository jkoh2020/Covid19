using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public string StateName { get; set; }
        public int Population { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public virtual List<StateData> StateData { get; set; }
       
    }
}
