#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a matrix of EnvDTE.Configuration objects, one for each combination
    //     of configuration name and platform name.
    [Guid("9043FDA1-345B-4364-900F-BC8598EB8E4F")]
    //[TypeLibType(4160)]
    public interface ConfigurationManager : IEnumerable
    {
        // Summary:
        //     Gets the current solution configuration that will be used if a solution build
        //     operation occurs.
        //
        // Returns:
        //     A EnvDTE.Configuration object.
        [DispId(13)]
        Configuration ActiveConfiguration { get; }
        //
        // Summary:
        //     Gets an array of all defined configuration names for the project or project
        //     item.
        //
        // Returns:
        //     An array of all defined configuration names for the project or project item.
        [DispId(7)]
        object ConfigurationRowNames { get; }
        //
        // Summary:
        //     Gets a value indicating the number of objects in the collection.
        //
        // Returns:
        //     An integer representing the number of objects in the collection.
        [DispId(3)]
        int Count { get; }
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
        //     Gets the immediate parent object of a EnvDTE.ConfigurationManager object.
        //
        // Returns:
        //     An object.
        [DispId(2)]
        object Parent { get; }
        //
        // Summary:
        //     Gets a list of all available platforms.
        //
        // Returns:
        //     An object.
        [DispId(11)]
        object PlatformNames { get; }
        //
        // Summary:
        //     Gets a list of platform names that can be added to this project and which
        //     may be added to create build configurations.
        //
        // Returns:
        //     A SafeArray of strings.
        [DispId(12)]
        object SupportedPlatforms { get; }

        // Summary:
        //     Creates a new project or project item configuration row based on the EnvDTE.Configuration
        //     object of an existing project or project item configuration row.
        //
        // Parameters:
        //   NewName:
        //     Required. A unique name for the new project or project item configuration
        //     row.
        //
        //   ExistingName:
        //     Required. The name of the project or project item configuration row to copy
        //     in order to create the new one.
        //
        //   Propagate:
        //     Required. true if the project or project item configuration row should be
        //     propagated, false if not.
        //
        // Returns:
        //     A EnvDTE.Configurations collection.
        [DispId(5)]
        Configurations AddConfigurationRow(string NewName, string ExistingName, bool Propagate);
        //
        // Summary:
        //     Creates build settings for a new operating system platform based on the EnvDTE.Configuration
        //     object of an existing platform.
        //
        // Parameters:
        //   NewName:
        //     Required. The name of the new platform as found in the EnvDTE.ConfigurationManager.SupportedPlatforms
        //     property.
        //
        //   ExistingName:
        //     Required. The name of the platform to copy in order to create the new one.
        //
        //   Propagate:
        //     Required. true if the platform should be propagated, false if not.
        //
        // Returns:
        //     A EnvDTE.Configurations collection.
        [DispId(9)]
        Configurations AddPlatform(string NewName, string ExistingName, bool Propagate);
        //
        // Summary:
        //     Returns a collection of items representing build configurations for one configuration
        //     name, such as "Debug" or "Retail."
        //
        // Parameters:
        //   Name:
        //     Required. The name of the project or project item configuration to return.
        //
        // Returns:
        //     A EnvDTE.Configurations collection.
        [DispId(4)]
        Configurations ConfigurationRow(string Name);
        //
        // Summary:
        //     Deletes a row of build configurations, such as for "Debug" or "Retail."
        //
        // Parameters:
        //   Name:
        //     Required. The name of the project/project item configuration row to delete.
        [DispId(6)]
        void DeleteConfigurationRow(string Name);
        //
        // Summary:
        //     Removes a column of platform configurations, such as "WinCE PalmSize."
        //
        // Parameters:
        //   Name:
        //     Required. The name of the platform to delete.
        [DispId(10)]
        void DeletePlatform(string Name);
        //
        // Summary:
        //     Returns an enumerator for items in the collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns a EnvDTE.Configuration object of a EnvDTE.ConfigurationManager collection.
        //
        // Parameters:
        //   index:
        //     Required. An absolute index, GUID string, or the name of a configuration.
        //
        //   Platform:
        //     Optional. The name of the platform.
        //
        // Returns:
        //     A EnvDTE.Configuration object.
        [DispId(0)]
        Configuration Item(object index, string Platform = "");
        //
        // Summary:
        //     Returns the EnvDTE.Configurations for this configuration.
        //
        // Parameters:
        //   Name:
        //     Required. The name of the platform's settings to return.
        //
        // Returns:
        //     A EnvDTE.Configurations collection.
        [DispId(8)]
        Configurations Platform(string Name);
    }
}
