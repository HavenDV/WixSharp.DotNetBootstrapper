﻿using System;
using System.IO;
using System.Linq;

namespace WixSharp
{
    /// <summary>
    /// Returns path to latest version of NuGet package by name.
    /// </summary>
    public static class PackageLocator
    {
        /// <summary>
        /// Returns path to latest version of NuGet package by name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetLatestVersionPath(string name)
        {
            var packagePath = @$"%userprofile%\.nuget\packages\{name}".ExpandEnvVars();
            var nsisVersion = Directory
                                  .GetDirectories(packagePath)
                                  .Select(Path.GetFileName)
                                  .Select<string, Version?>(fileName => new Version(fileName))
                                  .OrderDescending()
                                  .FirstOrDefault()
                              ?? throw new InvalidOperationException($"Can't find \"{name}\" package.");

            return Path.Combine(packagePath, $"{nsisVersion}");
        }
    }
}
