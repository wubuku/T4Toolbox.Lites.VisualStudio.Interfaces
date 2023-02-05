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
    //     Contains all add-ins listed in the Add-In Manager dialog box if they are
    //     DTE.AddIns, or all of the add-ins loaded by a particular solution if they
    //     are ProjectSolution.AddIns.
    [Guid("50590801-D13E-4404-80C2-5CA30A4D0EE8")]
    //[TypeLibType(4160)]
    public interface AddIns : IEnumerable
    {
        // Summary:
        //     Gets a value indicating the number of objects in the EnvDTE.AddIns collection.
        //
        // Returns:
        //     An integer value indicating the number of objects in the EnvDTE.AddIns collection.
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
        //     Gets the immediate parent object of a EnvDTE.AddIns collection.
        //
        // Returns:
        //     The immediate parent object of a given object.
        [DispId(2)]
        object Parent { get; }

        // Summary:
        //     Adds an add-in to the collection of add-ins loaded when a particular solution
        //     loads. It fails if the collection is the DTE.AddIns collection.
        //
        // Parameters:
        //   ProgID:
        //     Required. The ProgID of the add-in to add to the collection.
        //
        //   Description:
        //     Required. A description for the add-in to add to the collection.
        //
        //   Name:
        //     Required. The name of the add-in to add to the collection.
        //
        //   Connected:
        //     Required. Indicates whether the add-in is currently loaded.
        //
        // Returns:
        //     An EnvDTE.AddIn object.
        [DispId(102)]
        AddIn Add(string ProgID, string Description, string Name, bool Connected);
        //
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
        //     Returns an EnvDTE.AddIn object in an EnvDTE.AddIns collection.
        //
        // Parameters:
        //   index:
        //     Required. The index of the EnvDTE.AddIn object to return.
        //
        // Returns:
        //     A EnvDTE.AddIn object.
        [DispId(0)]
        AddIn Item(object index);
        //
        // Summary:
        //     Updates the collection as if the user opened the Add-in Manager dialog box,
        //     or sets the object's window layout to the current window layout.
        [DispId(41)]
        void Update();
    }
}
