using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
   public class GetStates
    {
        public int StateId { get; set; }
        public Guid UserId { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
    }
}
