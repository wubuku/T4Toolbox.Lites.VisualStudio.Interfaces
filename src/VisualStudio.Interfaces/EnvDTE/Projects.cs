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
    //     Represents all of the projects of a given kind.
    [Guid("E3EC0ADD-31B3-461F-8303-8A5E6931257A")]
    //[TypeLibType(4160)]
    public interface Projects : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.Projects collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the EnvDTE.Projects
        //     collection.
        [DispId(10)]
        int Count { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(200)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets a GUID String indicating the kind or type of the object.
        //
        // Returns:
        //     A GUID string representing the type of object.
        [DispId(202)]
        string Kind { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Projects collection.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(2)]
        DTE Parent { get; }
        //
        // Summary:
        //     Gets a collection of all properties that pertain to the EnvDTE.Projects collection.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(201)]
        Properties Properties { get; }

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
        //     Returns an indexed member of a EnvDTE.Projects collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the item to return.
        //
        // Returns:
        //     A EnvDTE.Project object.
        [DispId(0)]
        Project Item(object index);
    }
}
