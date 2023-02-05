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
    //     Contains all of the properties of a given object that are contained in a
    //     generic collection of properties.
    [Guid("4CC8CCF5-A926-4646-B17F-B4940CAED472")]
    //[TypeLibType(4160)]
    public interface Properties : IEnumerable
    {
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(1)]
        object Application { get; }
        //
        // Summary:
        //     Gets a value indicating the number of objects in the collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the collection.
        [DispId(40)]
        int Count { get; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(100)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Properties collection.
        //
        // Returns:
        //     An object.
        [DispId(2)]
        object Parent { get; }

        // Summary:
        //     Gets an enumeration for items in a collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns an indexed member of a EnvDTE.Properties collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.Property object to return.
        //
        // Returns:
        //     A EnvDTE.Property object.
        [DispId(0)]
        Property Item(object index);
    }
}
