﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace WinFormsApp1
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int departmentID { get; set; }
        public int managerId { get; set;  }
        public string email { get; set; }
        public string enrollDate { get; set; }
    }
}
