﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "Sin nombre";
        public string Specialty { get; set; } = "Sin especialidad";
    }
}
