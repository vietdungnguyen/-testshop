﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]   
        public Guid ID { set; get; }     
        [Required]   
        public DateTime VisitedDate { set; get; }
        [Required]
        [MaxLength(50)]
        public string IPAdress { set; get; }
    }
}
