using System.IO;

namespace WixSharp
{
    /// <summary>
    /// 
    /// </summary>
    public static class WebVersions
    {
        /// <summary>
        /// 
        /// </summary>
        public static NetVersion Net472 { get; } = new NetVersion(
            Path.Combine(PackageLocator.GetLatestVersionPath("WixSharp.NetBootstrapper.Web"), @"net-installers\web\NDP472-KB4054531-Web.exe"), 
            @"HKLM:SOFTWARE\Microsoft\.NETFramework\v4.0.30319\SKUs\.NETFramework,Version=v4.7.2:",
            Condition.Net472_Installed,
            "Please install .NET 4.7.2 first.");
    }
}
