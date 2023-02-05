#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents an add-in listed in the Add-In Manager dialog box and provides
    //     information about an add-in to other add-in objects.
    [Guid("53A87FA1-CE93-48BF-958B-C6DA793C5028")]
    //[TypeLibType(4160)]
    public interface AddIn
    {
        // Summary:
        //     Returns the collection containing the EnvDTE.AddIn object that supports this
        //     property.
        //
        // Returns:
        //     An EnvDTE.AddIns collection.
        [DispId(2)]
        AddIns Collection { get; }
        //
        // Summary:
        //     Gets or sets a value indicating whether an add-in is loaded and connected.
        //
        // Returns:
        //     A Boolean value indicating whether an add-in is loaded and connected.
        [DispId(6)]
        bool Connected { get; set; }
        //
        // Summary:
        //     Gets or sets a string that represents the description for the EnvDTE.AddIn
        //     object.
        //
        // Returns:
        //     A string that represents the description for the EnvDTE.AddIn object.
        [DispId(0)]
        string Description { get; set; }
        //
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(301)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the GUID for the EnvDTE.AddIn object.
        //
        // Returns:
        //     A string representing the CLSID of the add-in as obtained from the add-in's
        //     registry entry.
        [DispId(4)]
        string Guid { get; }
        //
        // Summary:
        //     Gets the name of the EnvDTE.AddIn object.
        //
        // Returns:
        //     A string representing the name of the EnvDTE.AddIn object.
        [DispId(302)]
        string Name { get; }
        //
        // Summary:
        //     Sets or gets the object supporting the specified EnvDTE.AddIn object.
        //
        // Returns:
        //     An additional OLE automation object to support other add-ins.
        [DispId(7)]
        object Object { get; set; }
        //
        // Summary:
        //     Gets the ProgID based on the add-in's registry entry.
        //
        // Returns:
        //     A string representing the ProgID.
        [DispId(3)]
        string ProgID { get; }
        //
        // Summary:
        //     Gets the location of a DLL containing localized resources, if available.
        //
        // Returns:
        //     A string representing the path of a DLL containing localized resources.
        [DispId(304)]
        string SatelliteDllPath { get; }

        // Summary:
        //     Removes the add-in from the collection of add-ins and makes it unavailable.
        [DispId(303)]
        void Remove();
    }
}
