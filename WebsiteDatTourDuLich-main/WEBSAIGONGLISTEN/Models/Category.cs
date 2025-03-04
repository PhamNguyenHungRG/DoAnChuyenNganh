﻿using System.ComponentModel.DataAnnotations;
using WEBSAIGONGLISTEN.Models;

namespace WEBSAIGONGLISTEN.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
        public List<TourDay>? TourDays { get; set; }
    }
}