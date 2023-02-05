#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The EnvDTE.Globals object is a cache for storing data for the duration of
    //     each session of the Visual Studio environment, as well as across sessions
    //     using the EnvDTE.Globals.this[System.String] property.
    [Guid("E68A3E0E-B435-4DDE-86B7-F5ADEFC19DF2")]
    //[TypeLibType(4160)]
    public interface Globals
    {
        // Summary:
        //     Gets the top-level extensibility object.
        //
        // Returns:
        //     A EnvDTE.DTE object.
        [DispId(1)]
        DTE DTE { get; }
        //
        // Summary:
        //     Gets the immediate parent object of a EnvDTE.Globals object.
        //
        // Returns:
        //     An object representing the parent object.
        [DispId(2)]
        object Parent { get; }
        //
        // Summary:
        //     Gets a list of all current global variable names.
        //
        // Returns:
        //     An object representing all of the current global variable names.
        [DispId(6)]
        object VariableNames { get; }

        // Summary:
        //     Returns or sets the variable with the specified name.
        //
        // Parameters:
        //   VariableName:
        //     Required. A string representing the name of the variable to retrieve.
        //
        // Returns:
        //     An object representing the variable.
        [DispId(0)]
        object this[string VariableName] { get; set; }

        [DispId(5)]
        bool get_VariableExists(string Name);
        [DispId(4)]
        bool get_VariablePersists(string VariableName);
        [DispId(4)]
        void set_VariablePersists(string VariableName, bool pVal);
    }
}
