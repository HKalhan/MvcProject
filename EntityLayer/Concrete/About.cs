﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [StringLength(1000)]
        public string AboutDetails1 { get; set; }
        [StringLength(1000)]
        public string AboutDetails2 { get; set; }
        [StringLength(100)]
        public string AboutDetailsImage1 { get; set; }
        [StringLength(100)]
        public string AboutDetailsImage2  { get; set; }
    }
}
