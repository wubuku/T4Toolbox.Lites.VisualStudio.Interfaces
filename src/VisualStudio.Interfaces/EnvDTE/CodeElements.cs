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
    //     A collection of objects representing code constructs in a source file.
    [Guid("0CFBC2B5-0D4E-11D3-8997-00C04F688DDE")]
    //[TypeLibType(4160)]
    public interface CodeElements : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.CodeElements
        //     collection.
        //
        // Returns:
        //     An integer value representing the number of objects in the EnvDTE.CodeElements
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
        //     Gets the immediate parent object of a EnvDTE.CodeElements collection.
        //
        // Returns:
        //     A parent object.
        [DispId(2)]
        object Parent { get; }

        // Summary:
        //     Creates a programmatic identifier that does not collide with other identifiers
        //     in the scope and that follows the current language naming rules.
        //
        // Parameters:
        //   Prefix:
        //     Required. The prefix string or whole name to check to see whether or not
        //     it is unique for the collection of code elements.
        //
        //   NewName:
        //     Optional. If supplied, this returns with a guaranteed unique name.
        //
        // Returns:
        //     A Boolean value indicating true if the name is a unique identifier; otherwise
        //     returns false.
        [DispId(5)]
        bool CreateUniqueID(string Prefix, ref string NewName);
        //
        // Summary:
        //     Returns an enumerator for items in the EnvDTE.CodeElements collection.
        //
        // Returns:
        //     An enumerator.
        [DispId(-4)]
        //[TypeLibFunc(1)]
        IEnumerator GetEnumerator();
        //
        // Summary:
        //     Returns a EnvDTE.CodeElement object in a EnvDTE.CodeElements collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.CodeElement object to return.
        //
        // Returns:
        //     A EnvDTE.CodeElement object.
        [DispId(0)]
        CodeElement Item(object index);
        //
        // Summary:
        //     Microsoft Internal Use Only.
        //
        // Parameters:
        //   Element:
        //     The element.
        [DispId(4)]
        //[TypeLibFunc(65)]
        void Reserved1(object Element);
    }
}
