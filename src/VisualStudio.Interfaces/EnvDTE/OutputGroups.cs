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
    //     Contains a collection of EnvDTE.OutputGroup objects.
    [Guid("F9FA748E-E302-44CF-891B-E263189D585E")]
    //[TypeLibType(4160)]
    public interface OutputGroups : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.OutputGroups
        //     collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the EnvDTE.OutputGroups
        //     collection.
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
        //     Gets the immediate parent object of an EnvDTE.OutputGroups collection.
        //
        // Returns:
        //     A EnvDTE.Configuration object.
        [DispId(2)]
        Configuration Parent { get; }

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
        //     Returns a EnvDTE.OutputGroup object in a EnvDTE.OutputGroups collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.OutputGroup object to return.
        //
        // Returns:
        //     An EnvDTE.OutputGroup object.
        [DispId(0)]
        OutputGroup Item(object index);
    }
}
