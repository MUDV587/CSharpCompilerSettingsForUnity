﻿using Coffee.CSharpCompilerSettings;
using NUnit.Framework;
using UnityEngine;

public class PackageInstallationTests
{
    [Test]
    public void Install_MicrosoftNetCompilers350()
    {
        var packageId = "Microsoft.Net.Compilers.3.5.0";
        var expected = Utils.PathCombine("Library", "InstalledPackages", packageId, "tools", "csc.exe");
        var actual = CompilerInfo.GetInstalledInfo(packageId).Path;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Install_MicrosoftNetCompilersToolset350()
    {
        var packageId = "Microsoft.Net.Compilers.Toolset.3.5.0";
        var expected = Utils.PathCombine("Library", "InstalledPackages", packageId, "tasks", "netcoreapp3.1", "bincore", "csc.dll");
        var actual = CompilerInfo.GetInstalledInfo(packageId).Path;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Install_OpenSesameNetCompilers350()
    {
        var packageId = "OpenSesame.Net.Compilers.3.5.0";
        var expected = Utils.PathCombine("Library", "InstalledPackages", packageId, "tools", "csc.exe");
        var actual = CompilerInfo.GetInstalledInfo(packageId).Path;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Install_OpenSesameNetCompilerToolset350()
    {
        var packageId = "OpenSesame.Net.Compilers.Toolset.3.5.0";
        var expected = Utils.PathCombine("Library", "InstalledPackages", packageId, "tasks", "netcoreapp3.1", "bincore", "csc.dll");
        var actual = CompilerInfo.GetInstalledInfo(packageId).Path;
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Install_Dotnet()
    {
        var version = "3.1.8";
        var packageId = "dotnet-runtime-" + version;
        var dotnetExe = Application.platform == RuntimePlatform.WindowsEditor ? "dotnet.exe" : "dotnet";
        var expected = Utils.PathCombine("Library", "InstalledPackages", packageId, dotnetExe);
        var actual =  RuntimeInfo.GetInstalledDotnetInfo(version).Path;
        Assert.AreEqual(expected, actual);
    }
}