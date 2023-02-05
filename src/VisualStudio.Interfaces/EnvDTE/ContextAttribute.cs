#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents a single attribute associated with a global context or window's
    //     context in the Dynamic Help window.
    [Guid("1A6E2CB3-B897-42EB-96BE-FF0FDB65DB2F")]
    //[TypeLibType(4160)]
    public interface ContextAttribute
    {
        // Summary:
        //     Gets the collection containing the EnvDTE.ContextAttribute object supporting
        //     this property.
        //
        // Returns:
        //     A EnvDTE.ContextAttributes collection.
        [DispId(2)]
        ContextAttributes Collection { get; }
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
        //     A string representing the name of object.
        [DispId(0)]
        string Name { get; }
        //
        // Summary:
        //     Gets a collection of values for the attribute.
        //
        // Returns:
        //     An object representing a SafeArray of strings containing the values of the
        //     attribute.
        [DispId(3)]
        object Values { get; }

        // Summary:
        //     Removes the attribute from its parent EnvDTE.ContextAttributes collection.
        [DispId(4)]
        void Remove();
    }
}
