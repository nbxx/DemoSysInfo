using System;

namespace Plugin.SysInfo.Abstractions
{
    /// <summary>
    /// Interface for SysInfo
    /// </summary>
    public interface ISysInfo
    {
        bool IsConnected { get; set; }

        string GetCpu();
    }
}
