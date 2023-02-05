#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a project or project item's build configuration dependent properties.
    [Guid("90813589-FE21-4AA4-A2E5-053FD274E980")]
    //[TypeLibType(4160)]
    public interface Configuration
    {
        // Summary:
        //     Returns the collection containing the EnvDTE.Configuration object supporting
        //     this property.
        //
        // Returns:
        //     A EnvDTE.ConfigurationManager collection.
        [DispId(2)]
        ConfigurationManager Collection { get; }
        //
        // Summary:
        //     Gets the project configuration to be built.
        //
        // Returns:
        //     A string representing the name of the project configuration to be built.
        [DispId(3)]
        string ConfigurationName { get; }
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
        //     Gets the Extender category ID (CATID) for the object.
        //
        // Returns:
        //     A string GUID representing the CATID.
        [DispId(14)]
        string ExtenderCATID { get; }
        //
        // Summary:
        //     Gets a list of available Extenders for the object.
        //
        // Returns:
        //     An object containing an automation-compliant array of strings.
        [DispId(13)]
        object ExtenderNames { get; }
        //
        // Summary:
        //     Gets whether the project or project item configuration can be built.
        //
        // Returns:
        //     A Boolean value indicating true if a project or project item should be built,
        //     false if not.
        [DispId(8)]
        bool IsBuildable { get; }
        //
        // Summary:
        //     Gets whether the project or project item configuration can be deployed.
        //
        // Returns:
        //     A Boolean value indicating true if a project or project item can be deployed,
        //     false if not.
        [DispId(10)]
        bool IsDeployable { get; }
        //
        // Summary:
        //     Returns whether the project or project item configuration can be run.
        //
        // Returns:
        //     A Boolean value indicating true if a project or project item can be run,
        //     false if not.
        [DispId(9)]
        bool IsRunable { get; }
        //
        // Summary:
        //     Gets an object that can be accessed by name at run time.
        //
        // Returns:
        //     An object that can be accessed by name at run time.
        [DispId(11)]
        object Object { get; }
        //
        // Summary:
        //     Gets a collection of EnvDTE.OutputGroup objects that contains the names of
        //     the files that are outputs for the project.
        //
        // Returns:
        //     A EnvDTE.OutputGroups collection.
        [DispId(15)]
        OutputGroups OutputGroups { get; }
        //
        // Summary:
        //     Gets the project or project item for the configuration.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(6)]
        object Owner { get; }
        //
        // Summary:
        //     Gets the name of the platform supported by this assignment.
        //
        // Returns:
        //     A string representing the name of the platform supported by this assignment.
        [DispId(4)]
        string PlatformName { get; }
        //
        // Summary:
        //     Gets a collection of all properties that pertain to the EnvDTE.Configuration
        //     object.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(7)]
        Properties Properties { get; }
        //
        // Summary:
        //     Gets a constant indicating the object type.
        //
        // Returns:
        //     A EnvDTE.vsConfigurationType constant, specifying the type of configuration.
        [DispId(5)]
        vsConfigurationType Type { get; }

        [DispId(12)]
        //[TypeLibFunc(1024)]
        object get_Extender(string ExtenderName);
    }
}
