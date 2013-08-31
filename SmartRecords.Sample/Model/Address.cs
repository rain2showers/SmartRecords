﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRecords.Sample.Model
{
    public class Address
    {
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; }

        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string Country { get; set; }
    }
}
