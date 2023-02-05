#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Indicatesthe type or state of a breakpoint.
    [Guid("75607DDE-2B43-11D3-B88B-00C04F79E479")]
    public enum dbgBreakpointType
    {
        // Summary:
        //     Breakpoint indicated a set of points in code.
        dbgBreakpointTypePending = 1,
        //
        // Summary:
        //     Breakpoint is at a specific point in code.
        dbgBreakpointTypeBound = 2,
    }
}
