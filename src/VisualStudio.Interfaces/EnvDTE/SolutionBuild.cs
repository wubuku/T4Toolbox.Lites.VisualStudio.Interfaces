#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents the root of the build automation model at the solution level.
    [Guid("A3C1C40C-9218-4D4C-9DAA-075F64F6922C")]
    //[TypeLibType(4160)]
    public interface SolutionBuild
    {
        //// Summary:
        ////     Gets the currently active EnvDTE.SolutionConfiguration object.
        ////
        //// Returns:
        ////     A EnvDTE.SolutionConfiguration object.
        //[DispId(3)]
        //SolutionConfiguration ActiveConfiguration { get; }
        ////
        //// Summary:
        ////     Gets a EnvDTE.BuildDependencies collection that allows you to specify which
        ////     projects depend on which other projects.
        ////
        //// Returns:
        ////     A EnvDTE.BuildDependencies collection.
        //[DispId(4)]
        //BuildDependencies BuildDependencies { get; }
        ////
        //// Summary:
        ////     Gets whether a build has ever been started in the current environment session,
        ////     whether a build is currently in progress, or whether a build has been completed.
        ////
        //// Returns:
        ////     A EnvDTE.vsBuildState value representing the status of the build operation.
        //[DispId(5)]
        //vsBuildState BuildState { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the number of projects that failed to build.
        //
        // Returns:
        //     The number of projects that failed to build.
        [DispId(6)]
        int LastBuildInfo { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.SolutionBuild object.
        //
        // Returns:
        //     A EnvDTE.Solution object.
        [DispId(2)]
        Solution Parent { get; }
        ////
        //// Summary:
        ////     Gets a collection of EnvDTE.SolutionConfiguration object.
        ////
        //// Returns:
        ////     A EnvDTE.SolutionConfigurations collection.
        //[DispId(13)]
        //SolutionConfigurations SolutionConfigurations { get; }
        //
        // Summary:
        //     Gets or sets the names of projects that are entry points for the application.
        //
        // Returns:
        //     An object containing the names of projects that are the entry points for
        //     the application.
        [DispId(7)]
        object StartupProjects { get; set; }

        // Summary:
        //     Causes the active solution configuration to begin building.
        //
        // Parameters:
        //   WaitForBuildToFinish:
        //     Optional. Determines whether EnvDTE.SolutionBuild.Build(System.Boolean) retains
        //     control until the build operation is complete. Default value is false.
        [DispId(8)]
        void Build(bool WaitForBuildToFinish = false);
        //
        // Summary:
        //     Builds the specified project and its dependencies in the context of the specified
        //     solution configuration.
        //
        // Parameters:
        //   SolutionConfiguration:
        //     Required. The name of the new solution configuration that provides the context
        //     in which to build the project.
        //
        //   ProjectUniqueName:
        //     Required. The project to build.
        //
        //   WaitForBuildToFinish:
        //     Optional. Determines whether to wait for the build to complete. If true,
        //     then waits, otherwise, no.
        [DispId(14)]
        void BuildProject(string SolutionConfiguration, string ProjectUniqueName, bool WaitForBuildToFinish = false);
        //
        // Summary:
        //     Deletes all compiler-generated support files for marked projects.
        //
        // Parameters:
        //   WaitForCleanToFinish:
        //     Optional. Determines whether EnvDTE.SolutionBuild.Build(System.Boolean) retains
        //     control until the build operation is complete. Default value is false.
        [DispId(11)]
        void Clean(bool WaitForCleanToFinish = false);
        //
        // Summary:
        //     Starts debugging the solution.
        [DispId(9)]
        void Debug();
        //
        // Summary:
        //     Causes each project in the active solution configuration that is marked for
        //     deployment to deploy.
        //
        // Parameters:
        //   WaitForDeployToFinish:
        //     Optional. Determines whether EnvDTE.SolutionBuild.Build(System.Boolean) retains
        //     control until the deployment operation is complete. Default value is false.
        [DispId(10)]
        void Deploy(bool WaitForDeployToFinish = false);
        //
        // Summary:
        //     Causes the active solution configuration to execute.
        [DispId(12)]
        void Run();
    }
}
