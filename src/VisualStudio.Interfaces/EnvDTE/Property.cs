#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Represents one property in a generic collection of properties for a given
    //     object.
    [Guid("7B988E06-2581-485E-9322-04881E0600D0")]
    //[TypeLibType(4160)]
    public interface Property
    {
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(1)]
        object Application { get; }
        //
        // Summary:
        //     Gets the EnvDTE.Property.Collection containing the EnvDTE.Property object
        //     supporting this property.
        //
        // Returns:
        //     A EnvDTE.Properties collection.
        [DispId(42)]
        Properties Collection { get; }
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
        //     Gets the name of the object.
        //
        // Returns:
        //     A string value representing the name of the object.
        [DispId(40)]
        string Name { get; }
        //
        // Summary:
        //     Gets the number of indices required to access the value.
        //
        // Returns:
        //     A short integer representing the number of indices required to access the
        //     value.
        [DispId(4)]
        short NumIndices { get; }
        //
        // Summary:
        //     Sets or gets the object supporting the EnvDTE.Property object.
        //
        // Returns:
        //     An object representing the value of the EnvDTE.Property object.
        [DispId(45)]
        object Object { get; set; }
        //
        // Summary:
        //     Microsoft Internal Use Only.
        [DispId(2)]
        Properties Parent { get; }
        //
        // Summary:
        //     Gets or sets the value of the property returned by the EnvDTE.Property object.
        //
        // Returns:
        //     An object.
        [DispId(0)]
        object Value { get; set; }

        [DispId(3)]
        //object get_IndexedValue(object Index1, object Index2 = Type.Missing, object Index3 = Type.Missing, object Index4 = Type.Missing);
        object get_IndexedValue(object Index1, object Index2, object Index3, object Index4);
        //
        // Summary:
        //     Setter function to set properties values.
        //
        // Parameters:
        //   lppvReturn:
        //     An object representing a value to set for a property
        [DispId(0)]
        void let_Value(object lppvReturn);
        //[DispId(3)]
        //void set_IndexedValue(object Index1, object Index2 = Type.Missing, object Index3 = Type.Missing, object Index4 = Type.Missing, object Val);
    }
}
