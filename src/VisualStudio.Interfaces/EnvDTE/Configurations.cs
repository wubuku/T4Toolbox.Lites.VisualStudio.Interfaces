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
    //     Contains a set of EnvDTE.Configuration objects. Each collection represents
    //     a row of EnvDTE.Configuration objects for a given configuration name and
    //     for each platform, or a column of each EnvDTE.Configuration object for a
    //     given platform name, one for each configuration name.
    [Guid("B6B4C8D6-4D27-43B9-B45C-52BD16B6BA38")]
    //[TypeLibType(4160)]
    public interface Configurations : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.Configurations
        //     collection.
        //
        // Returns:
        //     An integer indicating the number of objects in the collection.
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
        //     Gets the name of the object.
        //
        // Returns:
        //     A string representing the name of the object.
        [DispId(4)]
        string Name { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Configurations collection.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(2)]
        object Parent { get; }
        ////
        //// Summary:
        ////     Gets a constant indicating the Configurations type.
        ////
        //// Returns:
        ////     A EnvDTE.vsConfigurationType constant, specifying the type of configuration.
        //[DispId(5)]
        //vsConfigurationType Type { get; }

        // Summary:
        //     Gets an enumerator for items in the collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns a EnvDTE.Configuration object in a EnvDTE.Configurations collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of a EnvDTE.Configuration object to return.
        //
        // Returns:
        //     A EnvDTE.Configuration object.
        [DispId(0)]
        Configuration Item(object index);
    }
}
