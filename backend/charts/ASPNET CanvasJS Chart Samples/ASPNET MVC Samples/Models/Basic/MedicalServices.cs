﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_Samples.Models.Basic
{
    public class MedicalServices
    {
        public bool RequiredAccess { get; set; }

        public AccessLevel FamilyDoctor { get; set; }

        public AccessLevel SpecialisedMedicatCare { get; set; }

        public bool RequiredEmergency { get; set; }
    }

    public enum AccessLevel
    {
        VeryGood,
        Good,
        Fair,
        Bad,
        VeryBad
    }
}