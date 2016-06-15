using Plugin.SysInfo.Abstractions;
using System;


namespace Plugin.SysInfo
{
    /// <summary>
    /// Implementation for Feature
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
            return "android cpu";
        }
    }
}