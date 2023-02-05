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
    //     Contains all attributes associated with a global context or window's context
    //     in the Dynamic Help window.
    [Guid("33C5EBB8-244E-449D-9CEE-FAD70A774E59")]
    //[TypeLibType(4160)]
    public interface ContextAttributes : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.ContextAttributes
        //     collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the EnvDTE.ContextAttributes
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
        //     Gets the High Priority attributes collection.
        //
        // Returns:
        //     A EnvDTE.ContextAttributes collection.
        [DispId(6)]
        ContextAttributes HighPriorityAttributes { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.ContextAttributes collection.
        //
        // Returns:
        //     An object.
        [DispId(2)]
        object Parent { get; }
        //
        // Summary:
        //     Gets a constant indicating the object type.
        //
        // Returns:
        //     A EnvDTE.vsContextAttributes constant, specifying the context attribute.
        [DispId(5)]
        vsContextAttributes Type { get; }

        // Summary:
        //     Adds an attribute name/value pair to the EnvDTE.ContextAttributes collection.
        //
        // Parameters:
        //   AttributeName:
        //     Required. The name of the new attribute.
        //
        //   AttributeValue:
        //     Required. The value of the new attribute.
        //
        //   Type:
        //     Required. A EnvDTE.vsContextAttributeType constant specifying the type of
        //     new attribute.
        //
        // Returns:
        //     A EnvDTE.ContextAttribute object.
        [DispId(4)]
        ContextAttribute Add(string AttributeName, string AttributeValue, vsContextAttributeType Type);
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
        //     Returns a EnvDTE.ContextAttribute object that is an item of the EnvDTE.ContextAttributes
        //     collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.ContextAttribute object to return.
        //
        // Returns:
        //     A EnvDTE.ContextAttribute object.
        [DispId(0)]
        ContextAttribute Item(object index);
        //
        // Summary:
        //     Refresh the contents of this attribute collection.
        [DispId(7)]
        void Refresh();
    }
}
