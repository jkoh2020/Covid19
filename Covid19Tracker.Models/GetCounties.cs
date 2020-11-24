using Covid19Tracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Models
{
    public class GetCounties
    {

        [Key]
        public int CountyId { get; set; }
        public Guid UserId { get; set; }
        public string CountyName { get; set; }
        public int Population { get; set; }
        public virtual List<CountyData> CountyData { get; set; }



    }
}
