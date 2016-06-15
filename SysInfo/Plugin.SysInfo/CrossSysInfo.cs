using Plugin.SysInfo.Abstractions;
using System;

namespace Plugin.SysInfo
{
  /// <summary>
  /// Cross platform SysInfo implemenations
  /// </summary>
  public class CrossSysInfo
  {
    static Lazy<ISysInfo> Implementation = new Lazy<ISysInfo>(() => CreateSysInfo(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Current settings to use
    /// </summary>
    public static ISysInfo Current
    {
      get
      {
        var ret = Implementation.Value;
        if (ret == null)
        {
          throw NotImplementedInReferenceAssembly();
        }
        return ret;
      }
    }

    static ISysInfo CreateSysInfo()
    {
#if PORTABLE
        return null;
#else
        return new SysInfoImplementation();
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly()
    {
      return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
    }
  }
}
