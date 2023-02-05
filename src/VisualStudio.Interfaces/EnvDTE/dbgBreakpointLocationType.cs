#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     The breakpoint location type that is used by the EnvDTE.Breakpoint.LocationType
    //     property.
    [Guid("229C054C-C146-11D2-8AD1-00C04F79E479")]
    public enum dbgBreakpointLocationType
    {
        // Summary:
        //     There is no breakpoint.
        dbgBreakpointLocationTypeNone = 1,
        //
        // Summary:
        //     Breakpoint is a function.
        dbgBreakpointLocationTypeFunction = 2,
        //
        // Summary:
        //     Breakpoint is a file.
        dbgBreakpointLocationTypeFile = 3,
        //
        // Summary:
        //     Breakpoint is a data element.
        dbgBreakpointLocationTypeData = 4,
        //
        // Summary:
        //     Breakpoint is an address.
        dbgBreakpointLocationTypeAddress = 5,
    }
}
