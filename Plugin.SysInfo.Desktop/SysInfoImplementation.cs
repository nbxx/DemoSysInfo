﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.SysInfo.Abstractions;

namespace Plugin.SysInfo
{
    /// <summary>
    /// Implementation for SysInfo
    /// </summary>
    public class SysInfoImplementation : ISysInfo
    {
        public bool IsConnected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string GetCpu()
        {
            return "i7 cpu";
        }
    }
}
