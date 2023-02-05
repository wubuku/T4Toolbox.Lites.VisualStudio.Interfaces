#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     For conditional breakpoints. Indicates a break when the condition is true,
    //     or when it has changed. Used by the EnvDTE.Breakpoint.ConditionType property
    //     in the EnvDTE.Breakpoint object and by the EnvDTE.Breakpoints.Add(System.String,System.String,System.Int32,System.Int32,System.String,EnvDTE.dbgBreakpointConditionType,System.String,System.String,System.Int32,System.String,System.Int32,EnvDTE.dbgHitCountType)
    //     method in the EnvDTE.Breakpoints collection.
    [Guid("2A594772-C146-11D2-8AD1-00C04F79E479")]
    public enum dbgBreakpointConditionType
    {
        // Summary:
        //     Breaks when the condition is true.
        dbgBreakpointConditionTypeWhenTrue = 1,
        //
        // Summary:
        //     Breaks when the condition has changed.
        dbgBreakpointConditionTypeWhenChanged = 2,
    }
}
