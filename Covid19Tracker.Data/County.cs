using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class County
    {
        
        [Key]
        public int CountyId {get;set;}
        [Required]
        public string CountyName { get; set; }
        public int Population { get; set; }
        public Guid UserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public virtual List<CountyData> CountyData { get; set; }
        
    }
}
