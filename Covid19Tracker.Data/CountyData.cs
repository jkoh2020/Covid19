﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Data
{
    public class CountyData
    {
        
        [Key]
        public int DataId { get; set; }
        public int CountyId { get; set; }
        public string CountyName { get; set; }
        public int TodayTests{get;set;}
        public int TodayConfirmedCases { get; set; }
        public int TodayDeaths { get; set; }
        public Guid UserId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

    }
}
