﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelMSTestDataAccess.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        public string RoleTitle { get; set; }

        public string RoleDescription { get; set; }


        public List<Employee> Employee { get; set; }
    }
}
