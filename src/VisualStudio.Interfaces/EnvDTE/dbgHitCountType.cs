#region Assembly EnvDTE.dll, v8.0.0.0
// C:\Program Files (x86)\Common Files\Microsoft Shared\MSEnv\PublicAssemblies\EnvDTE.dll
#endregion

using System;
using System.Runtime.InteropServices;

namespace EnvDTE
{
    // Summary:
    //     Specifies a hit count condition.
    [Guid("3A3329CE-C146-11D2-8AD1-00C04F79E479")]
    public enum dbgHitCountType
    {
        // Summary:
        //     There is no hit count.
        dbgHitCountTypeNone = 1,
        //
        // Summary:
        //     Hit count is equal to specified value.
        dbgHitCountTypeEqual = 2,
        //
        // Summary:
        //     Hit count is greater than or equal to the specified value.
        dbgHitCountTypeGreaterOrEqual = 3,
        //
        // Summary:
        //     There are multiple hit count conditions.
        dbgHitCountTypeMultiple = 4,
    }
}
