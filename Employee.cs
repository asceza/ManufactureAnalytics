﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufactureAnalytics
{
    // Класс Сотрудник
    /// <summary>
    /// FullName - полное имя сотрудника<br/>
    /// LeadTimeInHours - затраченное время в часах
    /// </summary>
    class Employee
    {
        public string FullName { get; set; }
        public float LeadTimeInHours { get; set; }
        //public byte Rank { get; set; }

        public Employee(string fullName)
        {
            FullName = fullName;
            LeadTimeInHours = 0;
        }
    }
}
