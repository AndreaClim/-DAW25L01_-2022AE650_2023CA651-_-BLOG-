﻿using System.ComponentModel.DataAnnotations;

namespace L01_2022AE650_2023CA651.Models
{
    public class roles
    {
        [Key]
        public int rolId { get; set; }
        public string rol { get; set; }
    }
}
