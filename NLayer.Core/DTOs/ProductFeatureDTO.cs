﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class ProductFeatureDTO
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Witdh { get; set; }
        public int ProductId { get; set; }
    }
}
