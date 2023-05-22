using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace New_Gym.Models
{
    public class ProductModel
    {

        [Required]
        public string PDuration { get; set; }
        [Required]
        public string PPrice { get; set; }
        [Required]
        [AllowHtml]
        public string PDesc { get; set; }
    }
}