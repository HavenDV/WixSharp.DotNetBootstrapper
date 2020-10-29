# WixSharp.NetBootstrapper
Allows you to create a bootstrapper for an msi file in one line, simply by specifying the required .Net version

# NuGet
```
Install-Package WixSharp.NetBootstrapper.Web
```

# Usage
```cs
NetBootstrapper.Build(project, WebVersions.Net472);

// This is equivalent to
project.SetNetFxPrerequisite(version.Condition, version.ErrorMessage);
Compiler.BuildMsi(project);

NetBootstrapper.BuildExe(project, version);
```