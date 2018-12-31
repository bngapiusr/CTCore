﻿using System.ComponentModel.DataAnnotations;

namespace CTCore.Domain
{
    public class ClassType
    {
        public int ClassTypeId { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Description { get; set; }
    }
}