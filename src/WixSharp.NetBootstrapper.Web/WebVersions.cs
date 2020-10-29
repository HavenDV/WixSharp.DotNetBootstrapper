using System.IO;

namespace WixSharp
{
    /// <summary>
    /// Web installers for .Net Framework.
    /// </summary>
    public static class WebVersions
    {
        #region Constants

        /// <summary>
        /// .Net Framework 4.8.
        /// </summary>
        public static NetVersion Net48 { get; } = Create("ndp48-web", "4.8", Condition.Net48_Installed);

        /// <summary>
        /// .Net Framework 4.7.2.
        /// </summary>
        public static NetVersion Net472 { get; } = Create("NDP472-KB4054531-Web", "4.7.2", Condition.Net472_Installed);

        /// <summary>
        /// .Net Framework 4.7.1.
        /// </summary>
        public static NetVersion Net471 { get; } = Create("NDP471-KB4033344-Web", "4.7.1", Condition.Net471_Installed);

        /// <summary>
        /// .Net Framework 4.7.
        /// </summary>
        public static NetVersion Net47 { get; } = Create("NDP47-KB3186500-Web", "4.7", Condition.Net47_Installed);

        /// <summary>
        /// .Net Framework 4.6.2.
        /// </summary>
        public static NetVersion Net462 { get; } = Create("NDP462-KB3151802-Web", "4.6.2", Condition.Net462_Installed);

        /// <summary>
        /// .Net Framework 4.6.1.
        /// </summary>
        public static NetVersion Net461 { get; } = Create("NDP461-KB3102438-Web", "4.6.1", Condition.Net461_Installed);

        /// <summary>
        /// .Net Framework 4.6.
        /// </summary>
        public static NetVersion Net46 { get; } = Create("NDP46-KB3045560-Web", "4.6", Condition.Net46_Installed);

        /// <summary>
        /// .Net Framework 4.5.2.
        /// </summary>
        public static NetVersion Net452 { get; } = Create("NDP452-KB2901954-Web", "4.5.2", Condition.Net452_Installed);

        /// <summary>
        /// .Net Framework 4.5.1.
        /// </summary>
        public static NetVersion Net451 { get; } = Create("NDP451-KB2859818-Web", "4.5.1", Condition.Net451_Installed);

        /// <summary>
        /// .Net Framework 4.5.
        /// </summary>
        public static NetVersion Net45 { get; } = Create("dotNetFx45_Full_setup", "4.5", Condition.Net45_Installed);

        #endregion

        #region Utilities

        private static NetVersion Create(string exeName, string version, Condition condition)
        {
            return new NetVersion(
                Path.Combine(PackageLocator.GetLatestVersionPath("WixSharp.NetBootstrapper.Web"), @$"net-installers\web\{exeName}.exe"),
                @$"HKLM:SOFTWARE\Microsoft\.NETFramework\v4.0.30319\SKUs\.NETFramework,Version=v{version}:",
                condition,
                $"Please install .NET {version} first."
                );
        }

        #endregion
    }
}
