#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Contains the file names for a given named output group.
    [Guid("A3A80783-875F-435B-9639-E5CE888DF737")]
    //[TypeLibType(4160)]
    public interface OutputGroup
    {
        // Summary:
        //     Gets the unique name used for this output group.
        //
        // Returns:
        //     A string representing the name used for the output group.
        [DispId(5)]
        string CanonicalName { get; }
        //
        // Summary:
        //     Gets the collection containing the object supporting this property or contained
        //     within this code construct.
        //
        // Returns:
        //     An EnvDTE.OutputGroup collection.
        [DispId(2)]
        OutputGroups Collection { get; }
        //
        // Summary:
        //     Gets a string that represents the use of the output group.
        //
        // Returns:
        //     A string representing the use of the output group.
        [DispId(7)]
        string Description { get; }
        //
        // Summary:
        //     Gets the name used in the user interface for this output group.
        //
        // Returns:
        //     A string representing the name used in the user interface for this output
        //     group.
        [DispId(0)]
        string DisplayName { get; }
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
        //     Gets the number of files associated with an EnvDTE.OutputGroup .
        //
        // Returns:
        //     An integer indicating the number of files associated with an EnvDTE.OutputGroup.
        [DispId(4)]
        int FileCount { get; }
        //
        // Summary:
        //     Gets a list of all of the file names in the output group.
        //
        // Returns:
        //     An object containing a list of all the file names in the output group.
        [DispId(3)]
        object FileNames { get; }
        //
        // Summary:
        //     Gets the list of files built in this output group.
        //
        // Returns:
        //     An object containing the list of files built in this output group.
        [DispId(6)]
        object FileURLs { get; }
    }
}
