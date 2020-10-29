using System;
using System.IO;
using System.Linq;
using WixSharp.CommonTasks;
using WixSharp.Nsis;

namespace WixSharp
{
    /// <summary>
    /// 
    /// </summary>
    public static class NetBootstrapper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string BuildExe(Project project, NetVersion version)
        {
            Environment.SetEnvironmentVariable("WIXSHARP_NSISDIR", Path.Combine(
                PackageLocator.GetLatestVersionPath("NSIS-Tool"), 
                "tools"));

            return new NsisBootstrapper
            {
                DoNotPostVerifyPrerequisite = true,
                PrerequisiteFile = version.PrerequisiteFile,
                PrimaryFile = $"{project.OutFileName}.msi",
                OutputFile = $"{project.OutFileName}.exe",
                PrerequisiteRegKeyValue = version.PrerequisiteRegKeyValue,
            }.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public static string Build(Project project, NetVersion version)
        {
            project.SetNetFxPrerequisite(version.Condition, version.ErrorMessage);
            Compiler.BuildMsi(project);

            return BuildExe(project, version);
        }
    }
}
