#tool "nuget:?package=xunit.runner.console"
#tool "nuget:?package=OpenCover"

var configuration = Argument("configuration", "Release");
var target = Argument("target", "Default");

Task("Default").IsDependentOn("Test");

Task("Clean").Does(()=> 
{
    CleanDirectory("./build");
    StartProcess("dotnet", "clean -c:" + configuration);
});

Task("Restore").Does(()=> 
{
    DotNetCoreRestore();
});

Task("Build")
    .IsDependentOn("Clean")
    .IsDependentOn("Restore")
    .Does(()=> 
{
    var buildSettings =  new DotNetCoreBuildSettings { Configuration = configuration };

    DotNetCoreBuild("src/Perfvane.Example/Perfvane.Example.csproj",  buildSettings);
});

Task("Test").IsDependentOn("Build").Does(() =>
{
    DotNetCoreTest("./tests/Perfvane.Example.Tests/Perfvane.Example.Tests.csproj", new DotNetCoreTestSettings
    {
        Configuration = configuration,
        ArgumentCustomization = args => args.Append("/p:BuildProjectReferences=false")
    });
});

RunTarget(target);